using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    [Table("payment_type")]
    public class TipoPagamentoEntity : BaseEntity
    {
        [Column(name:"description")]
        public string Descricao { get; set; }

        [Column(name:"installments_number")]
        public int QrtParcelas { get; set; }

        [Column(name:"interest_percentage")]
        public double JurosPorcentagem { get; set; }
    }
}