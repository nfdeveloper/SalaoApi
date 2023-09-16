using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    [Table("service_category")]
    public class CatergoriaServicoEntity : BaseEntity
    {
        [Column(name:"description")]
        public string Descricao { get; set; }
    }
}