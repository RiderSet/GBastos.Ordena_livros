using GBastos.Ordena_livros.Domain;
using GBastos.Ordena_livros.Repositories.Interfaces;

namespace GBastos.Ordena_livros.Repositories
{
    public class LivroRepositoryInMemory : ILivroRepository
    {
        private readonly List<Livro> _livros = new()
    {
        new Livro
        {
            Titulo = "Java How to Program",
            Autor = "Deitel & Deitel",
            Edicao = 2007
        },
        new Livro
        {
            Titulo = "Patterns of Enterprise Application Architecture",
            Autor = "Martin Flower",
            Edicao = 2002
        },
        new Livro
        {
            Titulo = "Head First Design Patterns",
            Autor = "Elisabeth Freeman",
            Edicao = 2004
        },
        new Livro
        {
            Titulo = "Internet & World Wide Web: How to Program",
            Autor = "Deitel & Deitel",
            Edicao = 2007
        }
    };

        public IEnumerable<Livro> ObterTodos() => _livros;
    }
}
