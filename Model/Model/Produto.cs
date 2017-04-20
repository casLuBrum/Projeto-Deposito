using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }

        [Required]
        public Cliente ClienteID { get; set; }
        public virtual Cliente _Cliente { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        [Required]
        public double Peso { get; set; }

        [Required]
        public int Quantidade { get; set; }
    }
}
