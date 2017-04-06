using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    class ProdutoController
    {
        private static List<Produto> listaProdutos = new List<Produto>();

        public void Adicionar(Cliente cliID, string nome, double peso, int quant)
        {
            Produto prod = new Produto();
            prod.ProdutoID = listaProdutos.Count + 1;
            prod.ClienteID = cliID;
            prod.Nome = nome;
            prod.Peso = peso;
            prod.Quantidade = quant;

            listaProdutos.Add(prod);
        }

        private Produto BuscaPorID(int id)
        {
            foreach (Produto prod in listaProdutos)
            {
                if (prod.ProdutoID == id)
                {
                    return prod;
                }
            }
            return null;
        }

        public Produto Detalhes(int id)
        {
            return BuscaPorID(id);
        }

        public void Editar(int id, Cliente novoCli, string novoNome, double novoPeso, int novaQuant)
        {
            Produto prod = BuscaPorID(id);

            if(prod != null)
            {
                prod.ClienteID = novoCli;
                prod.Nome = novoNome;
                prod.Peso = novoPeso;
                prod.Quantidade = novaQuant;
            }
        }

        public List<Produto> Listar()
        {
            return listaProdutos;
        }
    }
}
