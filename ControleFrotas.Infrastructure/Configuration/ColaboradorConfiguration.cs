using ControleFrotas.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFrotas.Infrastructure.Configuration
{
    public class ColaboradorConfiguration : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("Colaboradores");
            builder.HasKey(e => e.Id);
            builder.Property(p => p.Id)
                .IsRequired();
            builder.Property(p => p.Nome)
                .IsRequired();
            builder.Property(p => p.Rg)
                .IsRequired();
            builder.Property(p => p.CPF)
                .IsRequired();
        }
    }
}
