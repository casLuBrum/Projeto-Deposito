using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.DAL;

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

        public static void EditarCliente(int id, Cliente novosDadosCli)
        {
            using (Contexto ctx = new Contexto())
            {
                Cliente dadosAntigoCliente = BuscarClientePorID(id, ctx);
                if (dadosAntigoCliente != null)
                {
                    dadosAntigoCliente.Nome = novosDadosCli.Nome;
                    dadosAntigoCliente.CPF = novosDadosCli.CPF;

                    ctx.Entry(dadosAntigoCliente).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
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



    }
}
