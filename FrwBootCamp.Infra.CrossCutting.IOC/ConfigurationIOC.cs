using Autofac;
using AutoMapper;
using FrameBook.Business.DTO.DTO;
using FrameBook.Business.Interfaces;
using FrameBook.Business.Service;
using FrameBook.Domain.Interfaces.Repositories;
using FrameBook.Domain.Interfaces.Services;
using FrameBook.Domain.Models;
using FrameBook.Domain.Services;
using FrameBook.Infra.Repository;
using System.Collections.Generic;

namespace FrameBook.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC Application
            builder.RegisterType<BusinessServiceGestaoStack>().As<IBusinessServiceGestaoStack>();
            builder.RegisterType<BusinessServiceGestaoProfissional>().As<IBusinessServiceGestaoProfissional>();
            builder.RegisterType<BusinessServiceGestaoAuth>().As<IBusinessServiceGestaoAuth>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceStack>().As<IServiceStack>();
            builder.RegisterType<ServiceProfissional>().As<IServiceProfissional>();
            builder.RegisterType<ServiceRefreshToken>().As<IServiceRefreshToken>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryStack>().As<IRepositoryStack>();
            builder.RegisterType<RepositoryProfissional>().As<IRepositoryProfissional>();
            builder.RegisterType<RepositoryRefreshToken>().As<IRepositoryAuth>();
            #endregion

            #region IOC Mapper
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                #region Stack
                cfg.CreateMap<Stack, StackDTO>();
                cfg.CreateMap<StackDTO, Stack>();
                cfg.CreateMap<List<StackDTO>, List<Stack>>();
                cfg.CreateMap<List<Stack>, List<StackDTO>>();
                #endregion

                #region RefreshToken
                cfg.CreateMap<RefreshToken, RefreshTokenDTO>();
                cfg.CreateMap<RefreshTokenDTO, RefreshToken>();
                cfg.CreateMap<List<RefreshTokenDTO>, List<RefreshToken>>();
                cfg.CreateMap<List<RefreshToken>, List<RefreshTokenDTO>>();
                #endregion

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
