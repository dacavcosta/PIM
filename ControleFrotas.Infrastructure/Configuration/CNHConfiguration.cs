using ControleFrotas.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFrotas.Infrastructure.Configuration
{
    public class CNHConfiguration : IEntityTypeConfiguration<CNH>
    {
        public void Configure(EntityTypeBuilder<CNH> builder)
        {
            builder.ToTable("CNHs");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Numero)
                .IsRequired();
            builder.Property(e => e.Registro)
                .IsRequired();
            builder.Property(e => e.Validade)
                .IsRequired();

            builder.HasOne(e => e.Colaborador)
                .WithOne(k => k.CNH)
                .HasForeignKey<CNH>(e => e.ColaboradorId);
        }

    }
}