using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Servico
{
    public interface IServicoService
    {
        Task<ServicoEntity> Get(int id);
        Task<IEnumerable<ServicoEntity>> GetAll();
        Task<ServicoEntity> Post(ServicoEntity servico);
        Task<ServicoEntity> Put(ServicoEntity servico);
        Task<bool> Delete(int id);
    }
}