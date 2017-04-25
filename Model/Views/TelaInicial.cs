using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente cadCliente = new FrmCadastrarCliente(null);
            cadCliente.MdiParent = this;
            cadCliente.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarClientes listCliente = new FrmListarClientes();
            listCliente.MdiParent = this;
            listCliente.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto cadProd = new FrmCadastrarProduto(null);
            cadProd.MdiParent = this;
            cadProd.Show();
        }
    }
}
