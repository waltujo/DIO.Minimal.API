using Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.DB
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {
        }

        public DbSet<Administrador> Administradores { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura o ID para ser gerado automaticamente
            modelBuilder.Entity<Administrador>().Property(a => a.Id).ValueGeneratedOnAdd();

            // Define o seed da entidade
            modelBuilder.Entity<Administrador>().HasData(
                new Administrador
                {
                    Id = -1, // Use um ID negativo para evitar colisões
                    Email = "adm@teste.com",
                    Password = "123456",
                    Perfil = "ADM"
                }
            );

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
