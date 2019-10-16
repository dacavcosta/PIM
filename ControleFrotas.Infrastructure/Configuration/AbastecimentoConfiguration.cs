using ControleFrotas.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFrotas.Infrastructure.Configuration
{
    public class AbastecimentoConfiguration : IEntityTypeConfiguration<Abastecimento>
    {
        public void Configure(EntityTypeBuilder<Abastecimento> builder)
        {
            builder.ToTable("Abastecimentos");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Data)
                .IsRequired();
            builder.Property(e => e.Responsavel)
                .IsRequired();
            builder.Property(e => e.Litros)
                .IsRequired();

            builder.HasOne(e => e.Veiculo)
                .WithMany(k => k.Abastecimentos)
                .HasForeignKey(e => e.VeiculoId);
        }
        
    }
}
