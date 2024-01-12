using TechChallengePhaseOne.Domain.Core.Interface.Repository;
using TechChallengePhaseOne.Domain.Core.Interface.Service;

namespace TechChallengePhaseOne.Domain.Service
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.FindById(id);
        }
    }
}