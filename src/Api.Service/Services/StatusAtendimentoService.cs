using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.StatusAtendimento;

namespace Api.Service.Services
{
    public class StatusAtendimentoService : IStatusAtendimentoService
    {
        private IRepository<StatusAtendimentoEntity> _repository;

        public StatusAtendimentoService(IRepository<StatusAtendimentoEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<StatusAtendimentoEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<StatusAtendimentoEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<StatusAtendimentoEntity> Post(StatusAtendimentoEntity statusAtendimento)
        {
            return await _repository.InsertAsync(statusAtendimento);
        }

        public async Task<StatusAtendimentoEntity> Put(StatusAtendimentoEntity statusAtendimento)
        {
            return await _repository.UpdateAsync(statusAtendimento);
        }
    }
}