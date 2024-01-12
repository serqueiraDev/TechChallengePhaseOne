using TechChallengePhaseOne.Domain.Core.Interface.Repository;
using TechChallengePhaseOne.Domain.Core.Interface.Service;
using TechChallengePhaseOne.Domain.Entity;

namespace TechChallengePhaseOne.Domain.Service
{
    public class ServiceContaInvestimento : ServiceBase<ContaInvestimento>, IServiceContaInvestimento
    {
        private readonly IRepositoryContaInvestimento _repositoryContaInvestimento;

        public ServiceContaInvestimento(IRepositoryContaInvestimento repositoryContaInvestimento) : base(repositoryContaInvestimento)
        {
            _repositoryContaInvestimento = repositoryContaInvestimento;
        }
    }
}