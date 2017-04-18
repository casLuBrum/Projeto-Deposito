using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }
        [Required, StringLength(30)]
        public string CPF { get; set; }
    }
}
