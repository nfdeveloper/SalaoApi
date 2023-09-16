using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.CategoriaServico
{
    public interface ICategoriaServicoService
    {
        Task<CategoriaServicoEntity> Get(int id);
        Task<IEnumerable<CategoriaServicoEntity>> GetAll();
        Task<CategoriaServicoEntity> Post(CategoriaServicoEntity categoria);
        Task<CategoriaServicoEntity> Put(CategoriaServicoEntity categoria);
        Task<bool> Delete(int id);
    }
}