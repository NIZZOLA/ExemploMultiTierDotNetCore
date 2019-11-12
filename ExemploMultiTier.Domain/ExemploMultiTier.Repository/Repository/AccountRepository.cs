using ExemploMultiTier.Domain.Interfaces.Repository;
using ExemploMultiTier.Domain.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Repository.Repository
{
    public class AccountRepository : BaseRepository<AccountModel>, IAccountRepository
    {
        public Result<decimal> GetSaldo(int accountId)
        {
            throw new NotImplementedException();
        }
    }
}
