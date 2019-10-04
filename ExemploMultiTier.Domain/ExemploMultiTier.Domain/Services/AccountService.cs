using ExemploMultiTier.Domain.Interfaces.Services;
using ExemploMultiTier.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Services
{
    public class AccountService : IAccountService
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<AccountModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public AccountModel GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public decimal GetSaldo(int accountId)
        {
            throw new NotImplementedException();
        }

        public AccountModel Insert(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public AccountModel Update(AccountModel account)
        {
            throw new NotImplementedException();
        }
    }
}
