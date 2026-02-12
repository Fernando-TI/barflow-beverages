using BarFlow.Domain.Enums;
using BarFlow.Domain.Repositories;
using BarFlow.Domain.Entities;

namespace BarFlow.Application.Services
{
    public class BebidaService
    {
        //private readonly IBebidaRepository _repository;
        private readonly IBebidaRepository _bebidaRepository;
        public BebidaService(IBebidaRepository bebidaRepository)
        {
            _bebidaRepository = bebidaRepository;
        }

        public void Criar(string nome, TipoBebida tipo, decimal preco)
        {
            var bebida = new Bebida(nome, tipo, preco);

            _bebidaRepository.Adicionar(bebida);
        }

        public void Atualizar(Guid id, string nome, TipoBebida tipo, decimal preco)
        {
            var bebida = _bebidaRepository.ObterPorId(id);
            if (bebida == null)
            {
                throw new Exception("Bebida não encontrada.");

            }
            
            bebida.AtualizarDados(nome, tipo, preco);

            _bebidaRepository.Atualizar(bebida);
        }
        public IEnumerable<Bebida> ObterTodas()
        {
            return _bebidaRepository.ObterTodas();
        }

    }
}
