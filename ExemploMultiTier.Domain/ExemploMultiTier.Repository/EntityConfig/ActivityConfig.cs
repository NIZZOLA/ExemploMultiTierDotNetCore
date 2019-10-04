using ExemploMultiTier.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Repository.EntityConfig
{
    public class ActivityConfig : IEntityTypeConfiguration<ActivityModel>
    {
        public void Configure(EntityTypeBuilder<ActivityModel> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasOne(a => a.Account)
                .WithMany(pai => pai.Activities)
                .HasForeignKey(a => a.AccountId);

            builder.Property(a => a.Description).HasMaxLength(100);

            builder.ToTable("Activity");
        }
    }
}
