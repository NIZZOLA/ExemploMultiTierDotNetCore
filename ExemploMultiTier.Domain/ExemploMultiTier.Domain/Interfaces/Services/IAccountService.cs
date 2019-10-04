using ExemploMultiTier.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Interfaces.Services
{
    public interface IAccountService : IBaseServiceInterface<AccountModel>
    {
        decimal GetSaldo(int accountId);


    }
}
