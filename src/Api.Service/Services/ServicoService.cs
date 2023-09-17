using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Servico;

namespace Api.Service.Services
{
    public class ServicoService : IServicoService
    {
        private IRepository<ServicoEntity> _repository;

        public ServicoService(IRepository<ServicoEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ServicoEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<ServicoEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<ServicoEntity> Post(ServicoEntity servico)
        {
            return await _repository.InsertAsync(servico);
        }

        public async Task<ServicoEntity> Put(ServicoEntity servico)
        {
            return await _repository.UpdateAsync(servico);
        }
    }
}