using ExemploMultiTier.Domain.Interfaces.Repository;
using ExemploMultiTier.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Repository.Ioc
{
    public interface IUnitOfWork
    {
        IBaseRepository<AccountModel> AccountRepository { get; }

    }
}
