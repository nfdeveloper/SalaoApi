using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities
{
    [Table("service_status")]
    public class StatusAtendimentoEntity : BaseEntity
    {
        [Column(name:"description")]
        public string Descricao { get; set; }
    }
}