using Autofac;
using AutoMapper;
using FrameBook.Business.DTO.DTO;
using FrameBook.Business.Interfaces;
using FrameBook.Business.Service;
using FrameBook.Domain.Interfaces.Repositories;
using FrameBook.Domain.Interfaces.Services;
using FrameBook.Domain.Models;
using FrameBook.Domain.Services;
using FrameBook.Infra.CrossCutting.Adapter.Interfaces;
using FrameBook.Infra.CrossCutting.Adapter.Map;
using FrameBook.Infra.Repository;
using System.Collections.Generic;

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
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Profissional, ProfissionalDTO>();
                cfg.CreateMap<ProfissionalDTO, Profissional>();
                cfg.CreateMap<List<ProfissionalDTO>, List<Profissional>>();
                cfg.CreateMap<List<Profissional>, List<ProfissionalDTO>>();
            })).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();
            #endregion
        }
    }
}
