using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarFlow.Domain.Entities;
using BarFlow.Domain.Enums;
using BarFlow.Domain.Repositories;

namespace BarFlow.Infrastructure.Repositories;
public class BebidaRepositoryEmMemoria : IBebidaRepository
{
    private readonly List<Bebida> _bebidas = new(); // Estado controlado; Simula banco; Evita acesso externo direto

    public IEnumerable<Bebida> ObterTodas()
    {
    return _bebidas;
    }

    public Bebida? ObterPorId(Guid id)
    {
        return _bebidas.FirstOrDefault(b => b.Id == id);

    }

    public void Adicionar(Bebida bebida)
    {
        if (_bebidas.Any(b => b.Id == bebida.Id)) //Validando duplicidade: Isso simula regra de integridade, não é CRUD burro
        {
            throw new InvalidOperationException("Bebida já cadastrada."); //erro de domínio, não é erro técnico, depois a API vai traduzir isso em HTTP 400/404

            _bebidas.Add(bebida);
        }
    }
    public void Atualizar(Bebida bebidaAtualizada)
    {
        var bebidaExistente = _bebidas.FirstOrDefault(b => b.Id == bebidaAtualizada.Id);

        if (bebidaExistente == null)
        {
            throw new Exception(" Bebida não encontrada.");
        }
        bebidaExistente.AtualizarDados(
            bebidaAtualizada.Nome,
            bebidaAtualizada.Tipo, 
            bebidaAtualizada.Preco
        );
    }


    public void Remover(Guid id)
    {
        var bebida = ObterPorId(id);

        if( bebida is null)
        {
            throw new InvalidOperationException("Bebida não encontrada.");
        }
        _bebidas.Remove(bebida);
    }

}


