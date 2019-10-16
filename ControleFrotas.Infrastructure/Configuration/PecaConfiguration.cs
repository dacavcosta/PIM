using ControleFrotas.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFrotas.Infrastructure.Configuration
{
    public class PecaConfiguration : IEntityTypeConfiguration<Peca>
    {
        public void Configure(EntityTypeBuilder<Peca> builder)
        {
            builder.ToTable("Pecas");
            builder.HasKey(e => e.Id);
            builder.Property(p => p.Nome)
                .IsRequired();

            builder.HasOne(e => e.Manutencao)
                .WithMany(k => k.Pecas)
                .HasForeignKey(e => e.ManutencaoId);
        }
    }
}
