using Microsoft.EntityFrameworkCore;
using Nepen.Models;
using System.IO;

namespace Nepen.Dados
{
    public class DbFilmes : DbContext
    {
        // classe que o Entity FrameworkCore vai gerenciar.
        public DbSet<FilmeModel> Filmes { get; set; }

        // Método de configuração do banco de Dados, sobreescrito pelo método OnConfiguring.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DbFilmes;Trusted_connection=true;");
        }

        // Método de aplicação das configurações para aplicação do modelo Filme no contexto de banco de dados.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
        }


    }
}
