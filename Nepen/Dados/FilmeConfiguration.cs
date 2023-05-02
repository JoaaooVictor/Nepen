using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Nepen.Models;

namespace Nepen.Dados
{
    // FilmeConfiguration sempre tem que herdar da IEntityTypeConfiguration pois é ela que mostra qual modelo será aplicado as configurações.
    public class FilmeConfiguration : IEntityTypeConfiguration<FilmeModel>
    {
        // Método Configure, usado para configurar o modo como a Migration deve criar as tabelas no banco de dados.
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
