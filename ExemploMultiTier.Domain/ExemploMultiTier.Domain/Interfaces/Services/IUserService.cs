using ExemploMultiTier.Domain.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Interfaces.Services
{
    interface IUserService : IBaseServiceInterface<UserModel>
    {
        Result<UserModel> Login(string usuario, string password);

        Result<bool> Logout();
    }
}
