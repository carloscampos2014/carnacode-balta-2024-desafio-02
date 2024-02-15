using Imc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Infrastructure.EntitiesConfiguration;

public class HistoriesConfiguration : IEntityTypeConfiguration<Histories>
{
    public void Configure(EntityTypeBuilder<Histories> builder)
    {
        builder.ToTable("histories");
        builder.HasKey(u => u.Id);
        
    }
}
