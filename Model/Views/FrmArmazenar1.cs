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
    public partial class FrmArmazenar1 : Form
    {
        public FrmArmazenar1()
        {
            InitializeComponent();
            
        }

        public void CarregarCbClientes()
        {
            ClienteController cliContr = new ClienteController();

            //cb_Cliente.DataSource = cliContr.Listar();

            cb_Cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Cliente.DataSource = cliContr.Listar();
            cb_Cliente.DisplayMember = "Nome";
            cb_Cliente.Update();
        }

        public void CarregarCbItens()
        {
            ProdutoController prodContr = new ProdutoController();

            cb_Itens.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Itens.DataSource = prodContr.Listar();
            cb_Itens.ValueMember = "ProdutoID";
            cb_Itens.DisplayMember = "Nome";
            cb_Itens.Update();
        }

        private void FrmArmazenar1_Load(object sender, EventArgs e)
        {
            CarregarCbClientes();
            CarregarCbItens();
        }
    }
}
