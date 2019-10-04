using ExemploMultiTier.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Interfaces.Services
{
    interface IUserService : IBaseServiceInterface<UserModel>
    {
        UserModel Login(string usuario, string password);

        bool Logout();


    }
}
