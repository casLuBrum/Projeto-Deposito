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

        public Cliente ClienteID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        [Required, StringLength(10)]
        public double Peso { get; set; }

        [Required, StringLength(10)]
        public int Quantidade { get; set; }
    }
}
