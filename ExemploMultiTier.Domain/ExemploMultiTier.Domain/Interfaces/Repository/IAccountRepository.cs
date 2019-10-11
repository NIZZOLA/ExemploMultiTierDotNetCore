using ExemploMultiTier.Domain.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Interfaces.Repository
{
    public interface IAccountRepository : IBaseRepository<AccountModel>
    {
        Result<decimal> GetSaldo(int accountId);
    }
}
