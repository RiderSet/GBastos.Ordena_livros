using GBastos.Ordena_livros.Domain;

namespace GBastos.Ordena_livros.Repositories.Interfaces
{
    public interface ILivroRepository
    {
        IEnumerable<Livro> ObterTodos();
    }
}
