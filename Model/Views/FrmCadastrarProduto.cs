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
    public partial class FrmCadastrarProduto : Form
    {
        public int? ProdutoID { get; set; }

        public FrmCadastrarProduto(int? idProduto)
        {
            InitializeComponent();

            if (idProduto.HasValue)
                ProdutoID = idProduto;
        }

        public void LimparCampos()
        {
            ProdutoID = null;
            nome_txt.Clear();
            peso_txt.Clear();

        }

        private bool Validar()
        {
            return !(string.IsNullOrEmpty(nome_txt.Text)) || !(string.IsNullOrEmpty(peso_txt.Text));
        }

        private void Salvar()
        {
            try
            {
                if (Validar())
                {
                    if (ProdutoID.HasValue)
                    {
                        Produto prod = new Produto();
                        prod.Nome = nome_txt.Text;
                        prod.Peso = Double.Parse(peso_txt.Text);

                        ProdutoController.EditarProduto(ProdutoID.Value, prod);

                        MessageBox.Show("Produto alterado com sucesso");

                        this.Close();
                    }
                    else
                    {
                        Produto prod = new Produto();
                        prod.Nome = nome_txt.Text;
                        prod.Peso = Double.Parse(peso_txt.Text);

                        ProdutoController.Salvar(prod);

                        MessageBox.Show("Produto Salvo com sucesso");
                        LimparCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Todos campos são obrigatórios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
