using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.CategoriaServico;

namespace Api.Service.Services
{
    public class CategoriaServicoService : ICategoriaServicoService
    {
        private IRepository<CategoriaServicoEntity> _repository;

        public CategoriaServicoService(IRepository<CategoriaServicoEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CategoriaServicoEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<CategoriaServicoEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<CategoriaServicoEntity> Post(CategoriaServicoEntity categoria)
        {
            return await _repository.InsertAsync(categoria);
        }

        public async Task<CategoriaServicoEntity> Put(CategoriaServicoEntity categoria)
        {
            return await _repository.UpdateAsync(categoria);
        }
    }
}