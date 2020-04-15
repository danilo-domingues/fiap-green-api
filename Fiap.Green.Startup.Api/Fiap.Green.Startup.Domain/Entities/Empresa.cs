using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Green.Startup.Domain.Entities
{
    [Table("EMPRESA")]
    public class Empresa
    {
        [Key]
        [Column("IdEmpresa")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string SegmentoEmpresa { get; set; }
        public bool ProgramaGreen { get; set; }

    }
}