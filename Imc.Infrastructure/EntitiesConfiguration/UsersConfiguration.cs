using Imc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Infrastructure.EntitiesConfiguration;

public class UsersConfiguration : IEntityTypeConfiguration<Users>
{
    public void Configure(EntityTypeBuilder<Users> builder)
    {
        builder.ToTable("users");
        builder.HasKey(u => u.Id);
        builder.Property(p => p.UserName)
            .IsRequired()
            .HasMaxLength(30);
        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(300);
        builder.Property(p => p.Password)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasMany(p => p.Histories)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId);
    }
}
