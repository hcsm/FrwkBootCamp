using Autofac;
using FrwkBootCamp.Domain.Interfaces.Repositories;
using FrwkBootCamp.Domain.Interfaces.Services;
using FrwkBootCamp.Domain.Services;
using FrwkBootCamp.Infra.CrossCutting.Adapter.Interfaces;
using FrwkBootCamp.Infra.CrossCutting.Adapter.Map;
using FrwkBootCamp.Infra.Repository;
using FrwkBootCamp.Pessoa.Application.Interfaces;
using FrwkBootCamp.Pessoa.Application.Service;

namespace FrwkBootCamp.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC Application
            builder.RegisterType<BusinessServiceGestaoPessoa>().As<IBusinessServiceGestaoPessoa>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServicePessoa>().As<IServicePessoa>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryPessoa>().As<IRepositoryPessoa>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperPessoa>().As<IMapperPessoa>();
            #endregion
        }
    }
}
