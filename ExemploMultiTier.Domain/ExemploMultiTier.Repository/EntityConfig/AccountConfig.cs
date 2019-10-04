using ExemploMultiTier.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Repository.EntityConfig
{
    public class AccountConfig : IEntityTypeConfiguration<AccountModel>
    {
        public void Configure(EntityTypeBuilder<AccountModel> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).HasMaxLength(100);
            builder.Property(a => a.AccountNumber).HasMaxLength(10);
            builder.Property(a => a.AgencyNumber).HasMaxLength(10);

            builder.ToTable("Account");
        }
    }
}
