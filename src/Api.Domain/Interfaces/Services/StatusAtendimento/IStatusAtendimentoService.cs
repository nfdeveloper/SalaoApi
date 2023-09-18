using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.StatusAtendimento
{
    public interface IStatusAtendimentoService
    {
        Task<StatusAtendimentoEntity> Get(int id);
        Task<IEnumerable<StatusAtendimentoEntity>> GetAll();
        Task<StatusAtendimentoEntity> Post(StatusAtendimentoEntity statusAtendimento);
        Task<StatusAtendimentoEntity> Put(StatusAtendimentoEntity statusAtendimento);
        Task<bool> Delete(int id);
    }
}