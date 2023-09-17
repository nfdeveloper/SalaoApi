using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.TipoPagamento;

namespace Api.Service.Services
{
    public class TipoPagamentoService : ITipoPagamentoService
    {
        private IRepository<TipoPagamentoEntity> _repository;

        public TipoPagamentoService(IRepository<TipoPagamentoEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<TipoPagamentoEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<TipoPagamentoEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<TipoPagamentoEntity> Post(TipoPagamentoEntity tipoPagamento)
        {
            return await _repository.InsertAsync(tipoPagamento);
        }

        public async Task<TipoPagamentoEntity> Put(TipoPagamentoEntity tipoPagamento)
        {
             return await _repository.UpdateAsync(tipoPagamento);
        }
    }
}