using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get;set; }
        public String Status { get;set; }
        public DateTime CreatedAt { get;set; } = DateTime.Now;
        public DateTime UpdatedAt { get;set; } = DateTime.Now;
        public String UsuarioCriacao { get;set; }
        public String UsuarioAlteracao { get;set; }
    }
}