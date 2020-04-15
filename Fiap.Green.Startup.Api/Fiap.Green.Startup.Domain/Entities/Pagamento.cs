using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Green.Startup.Domain.Entities
{
    [Table("PAGAMENTO")]
    public class Pagamento
    {
        [Key]
        [Column("IdPagamento")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPagamento { get; set; }
        public int IdTipoPagamento { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public string DadosPagamento { get; set; }
    }
}