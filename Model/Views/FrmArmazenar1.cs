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
        public int idSelecCliente { get; set; }
        public int idSelecItem { get; set; }

        public FrmArmazenar1()
        {
            InitializeComponent();
            
        }

        public void LimparCampos()
        {
            Prateleira_txt.Clear();
            Coluna_txt.Clear();
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
            cb_Itens.DisplayMember = "Nome";
            cb_Itens.Update();
        }

        private void FrmArmazenar1_Load(object sender, EventArgs e)
        {
            CarregarCbClientes();
            CarregarCbItens();
        }

        private void cb_Itens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_Itens.SelectedIndex > 0)
            idSelecItem = Convert.ToInt32(cb_Itens.SelectedValue);
        }

        private void cb_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Cliente.SelectedIndex > 0)
            {
                idSelecCliente = Convert.ToInt32(cb_Cliente.SelectedValue);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Armazenar armazenou = new Armazenar();
            armazenou.ClienteID = idSelecCliente;
            armazenou.ProdutoID = idSelecItem;
            armazenou.Prateleira = Int32.Parse(Prateleira_txt.Text);
            armazenou.Coluna = Int32.Parse(Coluna_txt.Text);

            ArmazenarController.Salvar(armazenou);

            MessageBox.Show("Item Armazenado com sucesso");
            LimparCampos();
        }
    }
}
