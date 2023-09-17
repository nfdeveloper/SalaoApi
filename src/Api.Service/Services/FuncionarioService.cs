using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Funcionario;

namespace Api.Service.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private IRepository<FuncionarioEntity> _repository;

        public FuncionarioService(IRepository<FuncionarioEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<FuncionarioEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<FuncionarioEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<FuncionarioEntity> Post(FuncionarioEntity funcionario)
        {
            return await _repository.InsertAsync(funcionario);
        }

        public async Task<FuncionarioEntity> Put(FuncionarioEntity funcionario)
        {
            return await _repository.UpdateAsync(funcionario);
        }
    }
}