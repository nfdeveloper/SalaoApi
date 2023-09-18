using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.AtendimentoService
{
    public interface IAtendimentoService
    {
        Task<AtendimentoEntity> Get(int id);
        Task<IEnumerable<AtendimentoEntity>> GetAll();
        Task<AtendimentoEntity> Post(AtendimentoEntity atendimento);
        Task<AtendimentoEntity> Put(AtendimentoEntity atendimento);
        Task<bool> Delete(int id);
    }
}