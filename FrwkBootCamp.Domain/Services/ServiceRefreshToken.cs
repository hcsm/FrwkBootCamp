using FrameBook.Domain.Interfaces.Repositories;
using FrameBook.Domain.Interfaces.Services;
using FrameBook.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameBook.Domain.Services
{
    public class ServiceRefreshToken : ServiceBase<RefreshToken>, IServiceRefreshToken
    {
        public readonly IRepositoryAuth _repositoryAuth;

        public ServiceRefreshToken(IRepositoryAuth repositoryAuth) : base(repositoryAuth)
        {
            _repositoryAuth = repositoryAuth;
        }
    }
}
