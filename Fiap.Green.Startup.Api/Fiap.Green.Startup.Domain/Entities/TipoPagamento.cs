using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Green.Startup.Domain.Entities
{
    [Table("TIPOPAGAMENTO")]
    public class TipoPagamento
    {
        [Key]
        [Column("IdTipoPagamento")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoPagamento { get; set; }
        public string Descricao { get; set; }
    }
}
