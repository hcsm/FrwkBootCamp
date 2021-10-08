﻿using AutoMapper;
using FrameBook.Authentication.Interfaces;
using FrameBook.Business.DTO.DTO;
using FrameBook.Domain.Interfaces.Services;
using FrameBook.Domain.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FrameBook.Authentication.Service
{
    public class ServiceToken : IServiceToken
    {
        private readonly IServiceProfissional _serviceProfissional;
        private readonly IServiceRefreshToken _serviceRefreshToken;
        private readonly IMapper _mapper;

        public ServiceToken(IServiceProfissional serviceProfissional, IServiceRefreshToken serviceRefreshToken, IMapper mapper)
        {
            _serviceProfissional = serviceProfissional;
            _serviceRefreshToken = serviceRefreshToken;
            _mapper = mapper;
        }

        public RefreshToken GenerateRefreshtoken(string email, string nome, string ipAddress)
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[64];
                rngCryptoServiceProvider.GetBytes(randomBytes);

                var refreshToken = new RefreshToken
                {
                    Token = Convert.ToBase64String(randomBytes),
                    Nome = nome,
                    Email = email,
                    Expires = DateTime.UtcNow.AddDays(7),
                    Created = DateTime.UtcNow,
                    CreatedByIp = ipAddress
                };

                var objRefreshToken = _mapper.Map<RefreshToken>(refreshToken);

                _serviceRefreshToken.Add(objRefreshToken);

                return refreshToken;
            }
        }

        public string GenerateToken(ProfissionalDTO obj, string secretKey = "")
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Role, obj.Nome),
                    new Claim(ClaimTypes.Email, obj.Email),
                    new Claim(ClaimTypes.Country, obj.Cidade),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),

                Expires = DateTime.UtcNow.AddHours(2),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public JwtSecurityToken Verify(string token, string secretKey = "")
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes(secretKey);

                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    RequireExpirationTime = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                return (JwtSecurityToken)validatedToken;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
