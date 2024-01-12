using TechChallengePhaseOne.Domain.Core.Interface.Repository;
using TechChallengePhaseOne.Domain.Entity;

namespace TechChallengePhaseOne.Data.Repository
{
    public class RepositoryAcao : RepositoryBase<Acao>, IRepositoryAcao
    {
        private readonly SqlContext _sqlContext;

        public RepositoryAcao(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}