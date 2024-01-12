namespace TechChallengePhaseOne.Domain.Core.Interface.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity FindById(int id);
    }
}