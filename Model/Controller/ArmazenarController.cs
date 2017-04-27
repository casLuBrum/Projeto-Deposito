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
    }
}
