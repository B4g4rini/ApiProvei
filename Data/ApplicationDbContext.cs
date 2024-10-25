using ApiProvei.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiProvei.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Patio> Patios { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Cliente>().ToTable("Clientes");
            builder.Entity<Locacao>().ToTable("Locacoes");
            builder.Entity<Veiculo>().ToTable("Veiculos");
            builder.Entity<Patio>().ToTable("Patios");

        }
    }

    
}
