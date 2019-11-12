using ExemploMultiTier.Domain.Interfaces.Repository;
using ExemploMultiTier.Repository.Context;
using FluentResults;
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

        public Result<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Result<ICollection<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Result<TEntity> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Result<TEntity> Insert(TEntity account)
        {
            throw new NotImplementedException();
        }

        public Result<TEntity> Update(TEntity account)
        {
            throw new NotImplementedException();
        }
    }
}
