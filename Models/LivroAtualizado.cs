namespace Desafio_Pratico_02_Rocketseat.Models;

public class LivroAtualizado
{
    public string? Titulo { get; set; }
    public string? Autor { get; set; }
    public string? Genero { get; set; }
    public decimal? Preco { get; set; }
    public int? QtdEstoque { get; set; }


    public void editarLivro(Livros livro, LivroAtualizado livroAtualizado)
    {
        if (!string.IsNullOrEmpty(livroAtualizado.Titulo))
        {
            livro.Titulo = livroAtualizado.Titulo;
        }

        if (!string.IsNullOrEmpty(livroAtualizado.Autor))
        {
            livro.Autor = livroAtualizado.Autor;
        }

        if (!string.IsNullOrEmpty(livroAtualizado.Genero))
        {
            livro.Genero = livroAtualizado.Genero;
        }

        if (livroAtualizado.Preco.HasValue)
        {
            livro.Preco = livroAtualizado.Preco.Value;
        }

        if (livroAtualizado.QtdEstoque.HasValue)
        {
            livro.QtdEstoque = livroAtualizado.QtdEstoque.Value;
        }
    }
}