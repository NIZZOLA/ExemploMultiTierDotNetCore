using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Insert(TEntity account);

        TEntity Update(TEntity account);

        bool Delete(int id);

        TEntity GetOne(int id);

        ICollection<TEntity> GetAll();

    }
}
