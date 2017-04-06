using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Produto
    {
        public int ProdutoID { get; set; }
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public int Quantidade { get; set; }
    }
}
