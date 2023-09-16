using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get;set; }
        [Column(name:"status")]
        public String Status { get;set; }
        [Column(name:"created_at")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get;set; } = DateTime.Now;
        [Column(name:"updated_at")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime UpdatedAt { get;set; } = DateTime.Now;
        public String UsuarioCriacao { get;set; }
        public String UsuarioAlteracao { get;set; }
    }
}