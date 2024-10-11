using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Desafio_Pratico_02_Rocketseat.Livros;

namespace Desafio_Pratico_02_Rocketseat.Controllers;
[Route("api/[controller]")]
[ApiController]
public class Biblioteca : ControllerBase
{
    private static List<Livros> livros = new List<Livros>();
    [HttpPost]
    public IActionResult adicionarLivro([FromBody] Livros livro)
    {
        try
        {
            if (livros == null) throw new Exception("Livro inválido");
            livros.Add(livro);
            return Ok($"Livro: {livro.Titulo} foi adicionado com sucesso!");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet]
    public IActionResult verLivros()
    {
        try
        {
            if (livros.Count == 0) throw new Exception("Lista vázia");
            return Ok(livros);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }
    [Route("{id}")]
    [HttpPut]
    public IActionResult editarLivro(int id, [FromBody] LivroAtualizacaoDTO livroAtualizado)
    {
        try
        {
            var livro = livros.FirstOrDefault(I => I.Id == id);
            if (livro == null) throw new Exception("Livro não encontrado");
            livro.editarLivro(livroAtualizado);
            return NoContent();

        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }
    [Route("{id}")]
    [HttpDelete]
    public IActionResult deletarLivro(int id)
    {
        try
        {
            var livro = livros.FirstOrDefault(I => I.Id == id);
            if (livro == null) throw new Exception("Livro não encontrado");
            livros.Remove(livro);
            return Ok();
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }

    }
}
