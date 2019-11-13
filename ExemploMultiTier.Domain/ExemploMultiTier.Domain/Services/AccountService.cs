using ExemploMultiTier.Domain.Interfaces.Repository;
using ExemploMultiTier.Domain.Interfaces.Services;
using ExemploMultiTier.Domain.Models;
using ExemploMultiTier.Domain.Validator;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Services
{
    public class AccountService : IAccountService
    {
        public IAccountRepository _accountRep;

        public AccountService(IAccountRepository accountRep)
        {
            _accountRep = accountRep;
        }

        public Result<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Result<ICollection<AccountModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Result<AccountModel> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Result<decimal> GetSaldo(int accountId)
        {
            throw new NotImplementedException();
        }

        public Result<AccountModel> Insert(AccountModel account)
        {
            var validationResult = new AccountModelValidator().Validate(account);
            if ( ! validationResult.IsValid )
            {
                return Results.Fail<AccountModel>(validationResult.Errors.ToString());
            }

            var businessResult = new AccountBusinessValidator().Validate(account);
            if( ! businessResult.IsValid )
            {
                return Results.Fail<AccountModel>(businessResult.Errors.ToString());
            }

            var result = _accountRep.Insert(account);

            if( result.IsFailed )
            {
                return Results.Fail<AccountModel>(result.Errors.ToString());
            }

            return Results.Ok<AccountModel>(result.Value);
        }

        public Result<AccountModel> Update(AccountModel account)
        {
            throw new NotImplementedException();
        }
    }
}
