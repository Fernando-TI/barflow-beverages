using BarFlow.Domain.Enums;
namespace BarFlow.Application.DTOs
{
    public class BebidaDto
    {
        public string Nome { get; set; }
        public TipoBebida Tipo { get; set; }

        public decimal Preco { get; set; }
    }
}
