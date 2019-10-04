using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Interfaces.Services
{
    public interface IBaseServiceInterface<TEntity> where TEntity:class
    {
        TEntity Insert(TEntity account);

        TEntity Update(TEntity account);

        bool Delete(int id);

        TEntity GetOne(int id);

        ICollection<TEntity> GetAll();


    }
}
