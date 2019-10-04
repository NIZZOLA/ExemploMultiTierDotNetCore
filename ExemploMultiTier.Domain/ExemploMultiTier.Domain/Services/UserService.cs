using ExemploMultiTier.Domain.Interfaces.Services;
using ExemploMultiTier.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Services
{
    public class UserService : IUserService
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<UserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserModel GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel Insert(UserModel account)
        {
            throw new NotImplementedException();
        }

        public UserModel Login(string usuario, string password)
        {
            throw new NotImplementedException();
        }

        public bool Logout()
        {
            throw new NotImplementedException();
        }

        public UserModel Update(UserModel account)
        {
            throw new NotImplementedException();
        }
    }
}
