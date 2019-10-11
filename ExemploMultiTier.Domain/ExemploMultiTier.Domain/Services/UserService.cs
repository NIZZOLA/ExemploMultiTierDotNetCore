using ExemploMultiTier.Domain.Interfaces.Services;
using ExemploMultiTier.Domain.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Services
{
    public class UserService : IUserService
    {
        public Result<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Result<ICollection<UserModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Result<UserModel> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Result<UserModel> Insert(UserModel account)
        {
            throw new NotImplementedException();
        }

        public Result<UserModel> Login(string usuario, string password)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Logout()
        {
            throw new NotImplementedException();
        }

        public Result<UserModel> Update(UserModel account)
        {
            throw new NotImplementedException();
        }
    }
}
