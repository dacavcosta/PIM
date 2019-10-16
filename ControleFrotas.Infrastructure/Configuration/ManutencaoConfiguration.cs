using ControleFrotas.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFrotas.Infrastructure.Configuration
{
    public class ManutencaoConfiguration : IEntityTypeConfiguration<Manutencao>
    {
        public void Configure(EntityTypeBuilder<Manutencao> builder)
        {
            builder.ToTable("Manutencoes");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Data)
                .IsRequired();
            builder.Property(e => e.Responsavel)
                .IsRequired();

            builder.HasOne(e => e.Veiculo)
                .WithMany(k => k.Manutencoes)
                .HasForeignKey(e => e.VeiculoId);
        }

    }
}