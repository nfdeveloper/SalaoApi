using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    [Table("customer_service")]
    public class AtendimentoEntity : BaseEntity
    {
        [Column(name:"amount",TypeName = "decimal(18,2)")]
        public double ValorTotal { get; set; }
        [Column(name:"amount_paid",TypeName = "decimal(18,2)")]
        public double ValorPago { get; set; }
        [Column(name:"amount_to_be_paid",TypeName = "decimal(18,2)")]
        public double ValorASerPago { get; set; }
        [Column(name:"scheduling_date")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataAgendamento { get;set; }
        [Column(name:"service_id")]
        public int ServicoEntityId { get; set; }
        public virtual ServicoEntity ServiceEntity { get; set; }
        [Column(name:"client_id")]
        public int ClienteId { get; set; }
        public virtual ClienteEntity ClienteEntity { get; set; }
        [Column(name:"employee_id")]
        public int FuncionarioId { get; set; }
        public virtual FuncionarioEntity FuncionarioEntity { get; set; }
        [Column(name:"payment_type_id")]
        public int TipoPagamentoId { get; set; }
        public virtual TipoPagamentoEntity TipoPagamentoEntity { get; set; }
        [Column(name:"service_status_id")]
        public int StatusAtendimentoId { get; set; }
        public virtual StatusAtendimentoEntity StatusAtendimentoEntity { get; set; }
    }
}