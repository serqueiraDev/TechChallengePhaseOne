using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TechChallengePhaseOne.Domain.Core.Interface.Repository;

namespace TechChallengePhaseOne.Data.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Add(TEntity entity)
        {
            try
            {
                _sqlContext.Set<TEntity>().Add(entity);
                _sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                _sqlContext.Entry(entity).State = EntityState.Modified;
                _sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                _sqlContext.Set<TEntity>().Remove(entity);
                _sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public TEntity FindById(int id)
        {
            return _sqlContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _sqlContext.Set<TEntity>().ToList();
        }
    }
}