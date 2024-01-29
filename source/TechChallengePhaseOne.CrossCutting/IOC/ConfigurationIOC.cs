using Autofac;
using TechChallengePhaseOne.Application;
using TechChallengePhaseOne.Application.Interface;
using TechChallengePhaseOne.Application.Mapper;
using TechChallengePhaseOne.Application.Mapper.Interface;
using TechChallengePhaseOne.Data.Repository;
using TechChallengePhaseOne.Domain.Core.Interface.Repository;
using TechChallengePhaseOne.Domain.Core.Interface.Service;
using TechChallengePhaseOne.Domain.Entity;
using TechChallengePhaseOne.Domain.Service;

namespace TechChallengePhaseOne.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder containerBuilder)
        {
            #region -- IOC --

            containerBuilder.RegisterType<ApplicationServiceAcao>().As<IApplicationServiceAcao>();
            containerBuilder.RegisterType<ApplicationServiceContaInvestimento>().As<IApplicationServiceContaInvestimento>();

            containerBuilder.RegisterType<ServiceAcao>().As<IServiceAcao>();
            containerBuilder.RegisterType<ServiceContaInvestimento>().As<IServiceContaInvestimento>();

            containerBuilder.RegisterType<RepositoryAcao>().As<IRepositoryAcao>();
            containerBuilder.RegisterType<RepositoryContaInvestimento>().As<IRepositoryContaInvestimento>();

            containerBuilder.RegisterType<MapperAcao>().As<IMapperAcao>();
            containerBuilder.RegisterType<MapperContaInvestimento>().As<IMapperContaInvestimento>();

            #endregion -- IOC --
        }
    }
}