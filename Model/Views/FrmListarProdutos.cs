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
    public partial class FrmListarProdutos : Form
    {
        public FrmListarProdutos()
        {
            InitializeComponent();
        }

        public void CarregarGridViewProdutos()
        {
            ProdutoController prodContr = new ProdutoController();

            dgv_Prod.DataSource = prodContr.Listar();
        }

        private void FrmListarProdutos_Load(object sender, EventArgs e)
        {
            CarregarGridViewProdutos();
        }

        private void dgv_Produtos_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells[0].Value);

                FrmCadastrarProduto cadProd = new FrmCadastrarProduto(idSelecionado);

                cadProd.ShowDialog();

                CarregarGridViewProdutos();
            }
        }
    }
}
