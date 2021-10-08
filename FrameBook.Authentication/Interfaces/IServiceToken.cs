using FrameBook.Business.DTO.DTO;
using FrameBook.Domain.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameBook.Authentication.Interfaces
{
    public interface IServiceToken
    {
        string GenerateToken(ProfissionalDTO obj, string secretKey = "");

        JwtSecurityToken Verify(string token, string secretKey = "");

        RefreshToken GenerateRefreshtoken(string email, string nome, string ipAddress);
    }
}
