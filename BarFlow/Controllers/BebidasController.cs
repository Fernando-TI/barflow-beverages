using Microsoft.AspNetCore.Mvc;
using BarFlow.Application.Services;
using BarFlow.Domain.Entities;
using BarFlow.Application.DTOs;
using BarFlow.Domain.Enums;
namespace BarFlow.API.Controllers
{
    [ApiController]
    [Route("api/bebidas")]
    public class BebidasController : ControllerBase
    {
        private readonly BebidaService _service;

        public BebidasController(BebidaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult ObterTodas()
        {
            var bebidas = _service.ObterTodas();
                return Ok(bebidas);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] BebidaDto dto ) {
            _service.Criar(dto.Nome, dto.Tipo, dto.Preco);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(Guid id) {

            _service.Remover(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, BebidaDto dto)
        {
            _service.Atualizar(id, dto.Nome, dto.Tipo, dto.Preco);

            return Ok();
        }

    }
}
/* Controller não cria bebida
 Controller não valida regra 
 Controller só expõe
 A lógica já existia antes */