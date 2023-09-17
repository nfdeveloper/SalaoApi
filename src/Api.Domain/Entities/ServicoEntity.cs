using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities
{
    [Table("service")]
    public class ServicoEntity : BaseEntity
    {
        [Column(name:"title")]
        public string Titulo { get; set; }
        [Column(name:"description")]
        public string Descricao { get; set; }
        [Column(name:"value")]
        public double Valor { get; set; }
        [Column(name:"duration_hours")]
        public int DuracaoHoras { get;set; }
        [Column(name:"duration_minutes")]
        public int DuracaoMinutos { get;set; } = 0;
        [Column(name:"categoria_servico_id")]
        public int CategoriaServicoEntityId { get; set; }
        public virtual CategoriaServicoEntity CategoriaServicoEntity { get; set; }
    }
}