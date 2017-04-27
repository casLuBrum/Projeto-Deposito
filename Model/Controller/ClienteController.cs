using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.DAL;
using System.Data.Entity;

namespace Controller
{
    public class ClienteController
    {

        public static void Salvar(Cliente cli)
        {
            using (Contexto ctx = new Contexto())
            {
                ctx.Clientes.Add(cli);
                ctx.SaveChanges();
            }
        }

        public static Cliente BuscarClientePorID(int id, Contexto ctx)
        {
            return ctx.Clientes.Find(id);
        }

        public Cliente Detalhes(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return BuscarClientePorID(id, ctx);
            }
        }

        public void EditarCliente(int id, string novoNome, string novoCpf)
        {
            using (Contexto ctx = new Contexto())
            {
                Cliente cliente = BuscarClientePorID(id, ctx);
                cliente.Nome = novoNome;
                cliente.CPF = novoCpf;

                ctx.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public static void Excluir(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Cliente cli = BuscarClientePorID(id, ctx);
                if (cli != null)
                {
                    ctx.Entry(cli).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }

       public List<Cliente> Listar()
        {
            using (Contexto ctx = new Contexto())
            {
                
                return ctx.Clientes.ToList(); ;
            }
        }

    }
}
