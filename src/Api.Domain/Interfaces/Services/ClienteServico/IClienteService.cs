using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.ClienteServico
{
    public interface IClienteService
    {   
        Task<ClienteEntity> Get(int id);
        Task<IEnumerable<ClienteEntity>> GetAll();
        Task<ClienteEntity> Post(ClienteEntity cliente);
        Task<ClienteEntity> Put(ClienteEntity cliente);
        Task<bool> Delete(int id);
    }
}