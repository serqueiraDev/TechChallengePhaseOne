using TechChallengePhaseOne.Domain.Core.Interface.Repository;
using TechChallengePhaseOne.Domain.Entity;

namespace TechChallengePhaseOne.Data.Repository
{
    public class RepositoryContaInvestimento : RepositoryBase<ContaInvestimento>, IRepositoryContaInvestimento
    {
        private readonly SqlContext _sqlContext;

        public RepositoryContaInvestimento(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}