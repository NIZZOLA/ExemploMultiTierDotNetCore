using FluentResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        Result<TEntity> Insert(TEntity account);

        Result<TEntity> Update(TEntity account);

        Result<bool> Delete(int id);

        Result<TEntity> GetOne(int id);

        Result<ICollection<TEntity>> GetAll();

    }
}
