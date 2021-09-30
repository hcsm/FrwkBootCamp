using FrwkBootCamp.Domain.Interfaces.Repositories;
using FrwkBootCamp.Domain.Interfaces.Services;
using FrwkBootCamp.Domain.Models;

namespace FrwkBootCamp.Domain.Services.Services
{
    public class ServicePessoa : ServiceBase<Pessoa>, IServicePessoa
    {
        public readonly IRepositoryPessoa _repositoryPessoa;

        public ServicePessoa(IRepositoryPessoa RepositoryPessoa)
            : base(RepositoryPessoa)
        {
            _repositoryPessoa = RepositoryPessoa;
        }
    }
}
