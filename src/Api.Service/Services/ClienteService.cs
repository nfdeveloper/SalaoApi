using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.ClienteServico;

namespace Api.Service.Services
{
    public class ClienteService : IClienteService
    {
        private IRepository<ClienteEntity> _repository;

        public ClienteService(IRepository<ClienteEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ClienteEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<ClienteEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<ClienteEntity> Post(ClienteEntity cliente)
        {
            return await _repository.InsertAsync(cliente);
        }

        public async Task<ClienteEntity> Put(ClienteEntity cliente)
        {
            return await _repository.UpdateAsync(cliente);
        }
    }
}