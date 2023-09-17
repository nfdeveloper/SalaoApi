using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    [Table("employee")]
    public class FuncionarioEntity : BaseEntity
    {
        [Column(name:"name")]
        public string Nome { get; set; }
        [Column(name:"nickname")]
        public string Apelido { get; set; }
        [Column(name:"age")]
        public int? Idade { get; set; }
        [Column(name:"cell_phone")]
        public string Celular { get; set; }
        [Column(name:"email")]
        public string? Email { get; set; }
        [Column(name:"earned_value",TypeName = "decimal(18,2)")]
        public double ValorGanho { get; set; } = 0.0;
        [Column(name:"services_performed")]
        public int ServicosFeitos { get; set; } = 0;
        [Column(name:"company_earned_value",TypeName = "decimal(18,2)")]
        public double ValorGanhoEmpresa { get; set; } = 0.0;
        [Column(name:"percentage",TypeName = "decimal(18,2)")]
        public double? Porcentagem { get; set; }
    }
}