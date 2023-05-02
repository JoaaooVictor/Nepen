using Microsoft.EntityFrameworkCore;
using Nepen.Models;
using System.IO;

namespace Nepen.Dados
{
    public class DbFilmes : DbContext
    {
        public DbSet<FilmeModel> Filmes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DbFilmes;Trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
        }


    }
}
