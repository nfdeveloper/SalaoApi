using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Funcionario
{
    public interface IFuncionarioService
    {
        Task<FuncionarioEntity> Get(int id);
        Task<IEnumerable<FuncionarioEntity>> GetAll();
        Task<FuncionarioEntity> Post(FuncionarioEntity funcionario);
        Task<FuncionarioEntity> Put(FuncionarioEntity funcionario);
        Task<bool> Delete(int id);
    }
}