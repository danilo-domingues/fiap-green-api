using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Green.Startup.Domain.Entities
{
    [Table("PESSOA")]
    public class Pessoa
    {
        [Key]
        [Column("IdPessoa")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }

    }
}
