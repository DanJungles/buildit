using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Caixa_Eletronico.Models
{
    [Table("Cedulas")]
    public class Cedulas
    {
        [Key]
        public int CedulaId { get; set; }
        public int Valor { get; set; }
        public int Quantidade { get; set; }
    }
}
