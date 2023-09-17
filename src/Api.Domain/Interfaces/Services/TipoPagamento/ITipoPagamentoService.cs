using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.TipoPagamento
{
    public interface ITipoPagamentoService
    {
        Task<TipoPagamentoEntity> Get(int id);
        Task<IEnumerable<TipoPagamentoEntity>> GetAll();
        Task<TipoPagamentoEntity> Post(TipoPagamentoEntity tipoPagamento);
        Task<TipoPagamentoEntity> Put(TipoPagamentoEntity tipoPagamento);
        Task<bool> Delete(int id);
    }
}