using TechChallengePhaseOne.Domain.Core.Interface.Repository;
using TechChallengePhaseOne.Domain.Core.Interface.Service;
using TechChallengePhaseOne.Domain.Entity;

namespace TechChallengePhaseOne.Domain.Service
{
    public class ServiceAcao : ServiceBase<Acao>, IServiceAcao
    {
        private readonly IRepositoryAcao _repositoryAcao;

        public ServiceAcao(IRepositoryAcao repositoryAcao) : base(repositoryAcao)
        {
            _repositoryAcao = repositoryAcao;
        }
    }
}