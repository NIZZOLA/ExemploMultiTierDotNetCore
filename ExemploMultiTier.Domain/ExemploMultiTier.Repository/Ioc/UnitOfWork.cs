using ExemploMultiTier.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Repository.Ioc
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ExemploDataContext context;

        public UnitOfWork(ExemploDataContext _context)
        {
            context = _context;
        }
    }
}
