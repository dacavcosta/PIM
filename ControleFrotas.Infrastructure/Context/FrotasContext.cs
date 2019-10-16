using ControleFrotas.Infrastructure.Configuration;
using ControleFrotas.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ControleFrotas.Infrastructure.Context
{
    public class FrotasContext : DbContext
    {
        public FrotasContext(DbContextOptions<FrotasContext> options) : base(options)
        {
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Peca> Pecas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new VeiculoConfiguration());
            //modelBuilder.ApplyConfiguration(new ColaboradorConfiguration());
            //modelBuilder.ApplyConfiguration(new PecaConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

