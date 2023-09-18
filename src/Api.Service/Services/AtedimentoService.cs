using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using Api.Domain.Interfaces.Services.AtendimentoService;

namespace Api.Service.Services
{
    public class AtedimentoService : IAtendimentoService
    {
        private IRepository<AtendimentoEntity> _repository;

        public AtedimentoService(IRepository<AtendimentoEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<AtendimentoEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<AtendimentoEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<AtendimentoEntity> Post(AtendimentoEntity atendimento)
        {
            return await _repository.InsertAsync(atendimento);
        }

        public async Task<AtendimentoEntity> Put(AtendimentoEntity atendimento)
        {
            return await _repository.UpdateAsync(atendimento);
        }
    }
}