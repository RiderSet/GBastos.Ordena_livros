using GBastos.Ordena_livros.Domain;
using GBastos.Ordena_livros.DTOs;
using GBastos.Ordena_livros.Repositories.Interfaces;

namespace GBastos.Ordena_livros.Services;

public class LivroService
{
    private readonly ILivroRepository _repository;

    public LivroService(ILivroRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Livro> OrdenarLivros(OrdenacaoRequestDto ordenacao)
    {
        var livros = _repository.ObterTodos();

        return (ordenacao.Campo.ToLower(), ordenacao.Direcao.ToLower()) switch
        {
            ("titulo", "asc") => livros.OrderBy(l => l.Titulo),
            ("titulo", "desc") => livros.OrderByDescending(l => l.Titulo),

            ("autor", "asc") => livros.OrderBy(l => l.Autor),
            ("autor", "desc") => livros.OrderByDescending(l => l.Autor),

            ("edicao", "asc") => livros.OrderBy(l => l.Edicao),
            ("edicao", "desc") => livros.OrderByDescending(l => l.Edicao),

            _ => livros
        };
    }
}

