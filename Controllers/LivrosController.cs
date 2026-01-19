using GBastos.Ordena_livros.DTOs;
using GBastos.Ordena_livros.Services;
using GBastos.Ordena_livros.Validators;
using Microsoft.AspNetCore.Mvc;

namespace GBastos.Ordena_livros.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LivrosController : ControllerBase
{
    private readonly LivroService _service;

    public LivrosController(LivroService service)
    {
        _service = service;
    }

    [HttpPost("ordenar")]
    public IActionResult OrdenacaoLivros([FromBody] OrdenacaoRequestDto request)
    {
        if (!OrdenacaoRequestValidator.Valido(request))
            return BadRequest("Critério de ordenação inválido.");

        var livrosOrdenados = _service.OrdenarLivros(request);

        var response = livrosOrdenados.Select(l => new LivroDto
        {
            Titulo = l.Titulo,
            Autor = l.Autor,
            Edicao = l.Edicao
        });

        return Ok(response);
    }
}
