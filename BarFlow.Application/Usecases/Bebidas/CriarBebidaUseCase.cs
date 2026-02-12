using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarFlow.Domain.Entities;
using BarFlow.Domain.Enums;
using BarFlow.Domain.Repositories;

namespace BarFlow.Application.Usecases.Bebidas
{
    public class CriarBebidaUseCase
    {
        private readonly IBebidaRepository _bebidaRepository;

        public CriarBebidaUseCase(IBebidaRepository bebidaRepository)
        {
            _bebidaRepository = bebidaRepository
            ?? throw new ArgumentNullException(nameof(bebidaRepository));
        }

        public Guid Executar(string nome, TipoBebida tipo, decimal preco)
        {
            if (string.IsNullOrWhiteSpace(nome)){
                throw new ArgumentException("Nome da bebida é obrigatório.");

            }
            if (preco <= 0) {
                throw new ArgumentException("Preço inválido.");

            }
            var bebida = new Bebida(nome, tipo , preco);

            _bebidaRepository.Adicionar(bebida);
            return bebida.Id;
            
        }
    }
}
