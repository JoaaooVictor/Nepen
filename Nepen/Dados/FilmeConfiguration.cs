using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Nepen.Models;

namespace Nepen.Dados
{
    public class FilmeConfiguration : IEntityTypeConfiguration<FilmeModel>
    {
        public void Configure(EntityTypeBuilder<FilmeModel> builder)
        {
            builder
                .Property(f => f.Id)
                .HasColumnType("int");
            builder
                .Property(f => f.Titulo)
                .HasColumnType("varchar(100)");
            builder
                .Property(f => f.Genero)
                .HasColumnType("varchar(20)");
            builder
                .Property(f => f.Classificacao)
                .HasColumnType("varchar(20)");

        }
    }
}
