using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarFlow.Domain.Entities;


namespace BarFlow.Domain.Repositories;

public interface IBebidaRepository
{
    IEnumerable<Bebida> ObterTodas();
    Bebida? ObterPorId(Guid Id);
    void Adicionar (Bebida bebida);

    void Atualizar(Bebida bebida);
    void Remover(Guid id);
}
