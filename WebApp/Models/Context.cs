using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configurations.PostgreSQLConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(Configurations.PostgreSQLDefaultSchema);
            base.OnModelCreating(modelBuilder);
        }
    }
}