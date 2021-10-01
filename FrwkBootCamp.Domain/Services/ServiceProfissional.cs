using FrameBook.Domain.Interfaces.Repositories;
using FrameBook.Domain.Interfaces.Services;
using FrameBook.Domain.Models;

namespace FrameBook.Domain.Services
{
    public class ServiceProfissional : ServiceBase<Profissional>, IServiceProfissional
    {
        public readonly IRepositoryProfissional _repositoryProfissional;

        public ServiceProfissional(IRepositoryProfissional repositoryProfissional)
            : base(repositoryProfissional)
        {
            _repositoryProfissional = repositoryProfissional;
        }
    }
}
