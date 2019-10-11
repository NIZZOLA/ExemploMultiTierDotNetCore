using ExemploMultiTier.Domain.Models;
using ExemploMultiTier.Repository.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Repository.Context
{
    public class ExemploDataContext : DbContext
    {
        public ExemploDataContext(DbContextOptions options ) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfig());
            modelBuilder.ApplyConfiguration(new ActivityConfig());
                
        }

        public DbSet<AccountModel> Accounts { get; set; }
        public DbSet<ActivityModel> Activitites { get; set; }

    }
}
