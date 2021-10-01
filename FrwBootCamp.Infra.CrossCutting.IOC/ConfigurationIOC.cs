using Autofac;
using FrameBook.Business.Interfaces;
using FrameBook.Business.Service;
using FrameBook.Domain.Interfaces.Repositories;
using FrameBook.Domain.Interfaces.Services;
using FrameBook.Domain.Services;
using FrameBook.Infra.CrossCutting.Adapter.Interfaces;
using FrameBook.Infra.CrossCutting.Adapter.Map;
using FrameBook.Infra.Repository;

namespace FrameBook.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC Application
            builder.RegisterType<BusinessServiceGestaoProfissional>().As<IBusinessServiceGestaoProfissional>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceProfissional>().As<IServiceProfissional>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryProfissional>().As<IRepositoryProfissional>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperProfissional>().As<IMapperProfissional>();
            #endregion
        }
    }
}
