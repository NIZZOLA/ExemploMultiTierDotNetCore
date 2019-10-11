using ExemploMultiTier.Domain.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Interfaces.Services
{
    public interface IAccountService : IBaseServiceInterface<AccountModel>
    {
        Result<decimal> GetSaldo(int accountId);
    }
}
