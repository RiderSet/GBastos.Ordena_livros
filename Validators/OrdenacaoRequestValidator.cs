using GBastos.Ordena_livros.DTOs;

namespace GBastos.Ordena_livros.Validators
{
    public static class OrdenacaoRequestValidator
    {
        private static readonly string[] CamposValidos =
            { "titulo", "autor", "edicao" };

        private static readonly string[] DirecoesValidas =
            { "asc", "desc" };

        public static bool Valido(OrdenacaoRequestDto dto)
        {
            return CamposValidos.Contains(dto.Campo.ToLower()) &&
                   DirecoesValidas.Contains(dto.Direcao.ToLower());
        }
    }
}
