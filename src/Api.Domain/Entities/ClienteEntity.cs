using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities
{
    [Table("client")]
    public class ClienteEntity : BaseEntity
    {
        [Column(name:"name")]
        public string Nome { get; set; }
        [Column(name:"nickname")]
        public string Apelido { get; set; }
        [Column(name:"age")]
        public int? Idade { get; set; }
        [Column(name:"gender")]
        public string Genero { get; set; }
        [Column(name:"cell_phone")]
        public string Celular { get; set; }
        [Column(name:"phone")]
        public string? Telefone { get; set; }
        [Column(name:"email")]
        public string? Email { get; set; }
        [Column(name:"instagram")]
        public string? Instagram { get; set; }
        [Column(name:"services_performed")]
        public int ServicosFeitos { get; set; } = 0;
        [Column(name:"amount_paid",TypeName = "decimal(18,2)")]
        public double ValorPago { get; set; } = 0.0;
    }
}