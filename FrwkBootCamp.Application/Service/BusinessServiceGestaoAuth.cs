using AutoMapper;
using FrameBook.Business.Interfaces;
using FrameBook.Domain.Interfaces.Services;
using FrameBook.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameBook.Business.Service
{
    public class BusinessServiceGestaoAuth : IBusinessServiceGestaoAuth
    {
        private readonly IServiceRefreshToken _serviceRefreshToken;
        private readonly IMapper _mapper;

        public BusinessServiceGestaoAuth(IServiceRefreshToken serviceRefreshToken, IMapper mapper)
        {
            _serviceRefreshToken = serviceRefreshToken;
            _mapper = mapper;
        }

        public ActionResult<dynamic> Add(RefreshToken obj)
        {
            var objRefreshToken = _mapper.Map<RefreshToken>(obj);
            _serviceRefreshToken.Add(objRefreshToken);

            return new { };
        }
    }
}
