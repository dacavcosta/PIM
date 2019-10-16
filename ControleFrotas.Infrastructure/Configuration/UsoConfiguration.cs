using ControleFrotas.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFrotas.Infrastructure.Configuration
{
    public class UsoConfiguration : IEntityTypeConfiguration<Uso>
    {
        public void Configure(EntityTypeBuilder<Uso> builder)
        {

            builder.ToTable("Usos");
            builder.HasKey(e => e.Id);
            builder.Property(p => p.KmInicial)
                    .IsRequired();
            builder.Property(p => p.Destino)
                    .IsRequired();
            builder.Property(p => p.Saida)
                    .IsRequired();
            builder.Property(p => p.Autorizacao)
                    .IsRequired();

            builder.HasOne(e => e.Veiculo)
                .WithMany(k => k.Usos)
                .HasForeignKey(e => e.VeiculoId);
            builder.HasOne(e => e.Colaborador)
                .WithMany(k => k.Usos)
                .HasForeignKey(e => e.ColaboradorId);
        }
    }
}
