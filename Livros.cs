using Microsoft.AspNetCore.Mvc;

namespace Desafio_Pratico_02_Rocketseat;

public class Livros
{

    public Guid Id { get; private set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; } = "Ficção";
    public decimal Preco { get; set; }
    public int QtdEstoque { get; set; }

    public Livros(string titulo, string autor, string genero, decimal preco, int qtdEstoque)
    {
        Id = Guid.NewGuid();
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
        Preco = preco;
        QtdEstoque = qtdEstoque;

    }

}
