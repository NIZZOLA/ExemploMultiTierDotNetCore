using ExemploMultiTier.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ExemploMultiTier.Domain.Interfaces.Services;
using FluentResults;

namespace ExemploMultiTier.Domain.Services
{
    public class ActivityService : IActivityService
    {
        public Result<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Result<ICollection<ActivityModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Result<ActivityModel> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Result<ActivityModel> Insert(ActivityModel account)
        {
            throw new NotImplementedException();
        }

        public Result<ActivityModel> Update(ActivityModel account)
        {
            throw new NotImplementedException();
        }
    }
}
