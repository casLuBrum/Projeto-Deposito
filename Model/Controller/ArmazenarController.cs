using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.DAL;
using Controller;

namespace Controller
{
    public class ArmazenarController
    {
        public static void Salvar(Armazenar arm)
        {
            using (Contexto ctx = new Contexto())
            {
                ctx.Armazenar.Add(arm);
                ctx.SaveChanges();
            }
        }

        //public static Armazenar BuscarPorCodigo(int id, Contexto ctx)
        

        public Armazenar RetornaBusca(int id)
        {
            using (Contexto ctx = new Contexto())
            {    
                return ctx.Armazenar.Find(id);
            }
        }


        public List<Armazenar> Listar()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Armazenar.ToList();
            }
        }
    }
}
