namespace Nepen.Models
{
    // Classe de modelagem de dados do filme.
    public class FilmeModel
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public int Duracao { get; set; }
        public string? Genero { get; set; }
        public string? Classificacao { get; set; }
    }
}
