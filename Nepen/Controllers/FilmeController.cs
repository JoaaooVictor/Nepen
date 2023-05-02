using Nepen.Dados;
using Nepen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApiNepen.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        #region Instância de Leitura
        // Instância de leitura para poder usar os métodos dos Entity dentro da classe Controller.
        private readonly DbFilmes _context;
        #endregion

        #region Construtor da classe
        // Construtor da classe usando o DbFilmes que está sendo gerenciado pelo Entity FrameworkCore.
        public FilmeController(DbFilmes context)
        {
            _context = context;
        }
        #endregion

        #region Pesquisar
        // Método Pesquisar filme por Id.
        [HttpGet("{id}")]
        public IActionResult Pesquisar(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(f => f.Id == id);

            if (filme == null)
            {
                return NotFound();
            }

            return Ok(filme);
        }
        #endregion

        #region Adicionar
        // Método de adicionar filme, usando como parâmetro o filme passado.
        [HttpPost]
        public IActionResult Adicionar(FilmeModel filme)
        {
            if (filme == null)
            {
                return BadRequest();
            }

            _context.Filmes.Add(filme);

            return CreatedAtAction(nameof(Pesquisar), new { id = filme.Id }, filme);
        }
        #endregion

        #region Atualizar
        // Método Atualizar, utilizando como parâmetro o Id e o filme a ser atualizado.
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, FilmeModel filme)
        {
            if (id != filme.Id)
            {
                return BadRequest();
            }

            var filmeAtual = _context.Filmes.FirstOrDefault(f => f.Id == id);

            if (filmeAtual == null)
            {
                return NotFound();
            }

            filmeAtual.Titulo = filme.Titulo;
            filmeAtual.Genero = filme.Genero;
            filmeAtual.Classificacao = filme.Classificacao;
            filmeAtual.Duracao = filme.Duracao;

            return NoContent();
        }
        #endregion

        #region Deletar
        // Método Deletar, usando como parâmetro o Id do filme.
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(f => f.Id == id);

            if (filme == null)
            {
                return NotFound();
            }

            _context.Filmes.Remove(filme);

            return NoContent();
        }
        #endregion

    }
}

