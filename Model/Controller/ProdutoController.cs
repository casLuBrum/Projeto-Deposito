using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.DAL;

namespace Controller
{
    public class ProdutoController
    {
       
        public static void Salvar(Produto prod)
        {
            using (Contexto ctx = new Contexto())
            {                
                ctx.Produtos.Add(prod);
                ctx.SaveChanges();
            }
        }

        private static Produto BuscarProdutoPorID(int id, Contexto ctx)
        {
            return ctx.Produtos.Find(id);
        }

        public static void EditarProduto(int id, Produto novosDadosProd)
        {
            using (Contexto ctx = new Contexto())
            {
                Produto dadosAntigosProduto = BuscarProdutoPorID(id, ctx);

                if (dadosAntigosProduto != null)
                {
                    dadosAntigosProduto.Nome = novosDadosProd.Nome;
                    dadosAntigosProduto.Peso = novosDadosProd.Peso;

                    ctx.Entry(dadosAntigosProduto).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
        }

        public static void ExcluirProduto(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Produto prod = BuscarProdutoPorID(id, ctx);

                if(prod != null)
                {
                    ctx.Entry(prod).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }

        public List<Produto> Listar()
        {
            using(Contexto ctx = new Contexto())
            {
                
                return ctx.Produtos.ToList();
            }
        }

    }
}
