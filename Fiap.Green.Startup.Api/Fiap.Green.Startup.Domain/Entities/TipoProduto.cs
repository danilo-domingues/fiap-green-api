using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Green.Startup.Domain.Entities
{

    [Table("TIPOPRODUTO")]
    public class TipoProduto
    {
        [Key]
        [Column("IdTipoProduto")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoProduto { get; set; }
        public string NomeTipoProduto { get; set; }

    }
}