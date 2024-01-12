﻿namespace TechChallengePhaseOne.Domain.Core.Interface.Service
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}