using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Green.Startup.Domain.Entities
{
    [Table("CLIENTE")]
    public class Cliente
    {
        [Key]
        [Column("IdCliente")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idcliente { get; set; }
        public DateTime DtUltimaCompra { get; set; }
        public Int64 QntCompras { get; set; }
        public Int64 NrPontos { get; set; }
        public int IdPessoa { get; set; }
        //Navigation Property
        public Pessoa Pessoa { get; set; }

    }
}