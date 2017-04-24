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
    public partial class FrmListarClientes : Form
    {
        public FrmListarClientes()
        {
            InitializeComponent();
        }

        private void FrmListarClientes_Load(object sender, EventArgs e)
        {
            CarregarGridViewClientes();
        }

        private void CarregarGridViewClientes()
        {
            dgv_Clientes.DataSource = null;

            ClienteController cliContr = new ClienteController();
            

            dgv_Clientes.DataSource = cliContr.Listar();        
        }

        

        private void dgv_Clientes_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells[0].Value);
               

                FrmCadastrarCliente cadCliente = new FrmCadastrarCliente(idSelecionado);
                
                cadCliente.ShowDialog();

                CarregarGridViewClientes();
            }
        }

        private void dgv_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
