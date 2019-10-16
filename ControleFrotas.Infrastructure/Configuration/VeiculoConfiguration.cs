using System;
using System.Collections.Generic;
using System.Text;
using ControleFrotas.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFrotas.Infrastructure.Configuration
{
    public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculos");

            builder.HasKey(e => e.Id);
            builder.Property(p => p.Marca)
                .IsRequired();
            builder.Property(p => p.Modelo)
                .IsRequired();
            builder.Property(p => p.Renavam)
                .IsRequired();
            builder.Property(p => p.NumeroChassi)
                .IsRequired();
            builder.Property(p => p.Ano)
                .IsRequired();
        }
    }
}
