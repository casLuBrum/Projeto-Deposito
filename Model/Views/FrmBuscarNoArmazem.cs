using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace Views
{
    public partial class FrmBuscarNoArmazem : Form
    {
        //Armazenar local = new Armazenar();
        List<Armazenar> local = new List<Armazenar>();

        public FrmBuscarNoArmazem()
        {
            InitializeComponent();
        }

        
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            ArmazenarController armContr = new ArmazenarController();

            local.Add(armContr.RetornaBusca(Convert.ToInt32(Codigo_txt.Text)));

            if (local != null)
            {
                CarregarGridViewBusca();
            }
            else
            {
                MessageBox.Show("Item não encontrado.");
                Codigo_txt.Clear();
            }
        }

        public void CarregarGridViewBusca()
        {
            //ArmazenarController armContr = new ArmazenarController();
            dgv_Busca.DataSource = null;
            dgv_Busca.DataSource = local;
            dgv_Busca.Refresh();
            //dgv_Busca.DataSource = armContr.Listar();
            
        }


        private void FrmBuscarNoArmazem_Load(object sender, EventArgs e)
        {
            CarregarGridViewBusca();
        }


    }
}
