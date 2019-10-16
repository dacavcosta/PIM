using ControleFrotas.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFrotas.Infrastructure.Configuration
{
    public class ReservaConfiguration : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {

            builder.ToTable("Reservas");
            builder.HasKey(e => e.Id);
            builder.Property(p => p.DataSolicitacao)
                    .IsRequired();
            builder.Property(p => p.Destino)
                    .IsRequired();

            builder.HasOne(e => e.Colaborador)
                .WithMany(k => k.Reservas)
                .HasForeignKey(e => e.ColaboradorId);
        }
    }
}
