using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ClienteController
    {
        private static List<Cliente> listaCliente = new List<Cliente>();
        public void Adicionar(string Nome, string CPF)
        {
            Cliente cli = new Cliente();
            cli.ClienteID = listaCliente.Count + 1;
            cli.Nome = Nome;
            cli.CPF = CPF;

            listaCliente.Add(cli);
            
        }

        private Cliente BuscarPorID(int ID)
        {
            foreach ( Cliente cli in listaCliente)
            {
                if(cli.ClienteID == ID)
                {
                    return cli;
                }
            }
            return null;
        }
        public Cliente Detalhes(int ID)
        {
            return BuscarPorID(ID);
        }
        public void Editar(int ID, string novoNome , string novoCPF)
        {
            Cliente C = BuscarPorID(ID);

            if( C != null)
            {
                C.Nome = novoNome;
                C.CPF = novoCPF;
            }
        }
        public void Excluir(int ID)
        {
            foreach(Cliente cli in listaCliente)
            {
                if(cli.ClienteID == ID)
                {
                    listaCliente.Remove(cli);
                }
            }
        }
        public List<Cliente> Listar()
        {
            return listaCliente;
        }
    }
}
