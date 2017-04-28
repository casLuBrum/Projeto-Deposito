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

        [Required, StringLength(30)]
        public string Nome { get; set; }

        [Required]
        public double Peso { get; set; }

    }
}
