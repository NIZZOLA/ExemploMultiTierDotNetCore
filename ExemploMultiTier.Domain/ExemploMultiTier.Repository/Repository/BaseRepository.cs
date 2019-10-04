using ExemploMultiTier.Domain.Interfaces.Repository;
using ExemploMultiTier.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected ExemploDataContext Db;
        protected DbSet<TEntity> DbSet;

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ICollection<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity account)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity account)
        {
            throw new NotImplementedException();
        }
    }
}
