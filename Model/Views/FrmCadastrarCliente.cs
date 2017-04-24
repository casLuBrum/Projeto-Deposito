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
    public partial class FrmCadastrarCliente : Form
    {
        public int? ClienteID { get; set; }
        public Cliente _Cliente { get; set; }

        public FrmCadastrarCliente(int? idCliente)
        {
            InitializeComponent();

            if (idCliente.HasValue)
                ClienteID = idCliente;
        }

        public void LimparCampos()
        {
            ClienteID = null;
            _Cliente = null;
            nome_txt.Clear();
            cpf_txt.Clear();
            btn_salvar.Text = "Salvar";
        }


        private void CarregarFormulario()
        {
            if (ClienteID.HasValue)
            { 
                ClienteController cliContr = new ClienteController();
                _Cliente = cliContr.Detalhes(ClienteID.Value);
                if (_Cliente != null)
                {
                    nome_txt.Text = _Cliente.Nome;
                    cpf_txt.Text = _Cliente.CPF;
                    btn_salvar.Text = "Atualizar";
                }
            }
            else
            {
                LimparCampos();
            }
        }

        private bool Validar()
        {
            return !(string.IsNullOrEmpty(nome_txt.Text)) || !(string.IsNullOrEmpty(cpf_txt.Text));
        }

        private void Salvar()
        {
            try
            {
                if (Validar())
                {
                    if (ClienteID.HasValue)
                    {
                        ClienteController cliContr = new ClienteController();
                        cliContr.EditarCliente(ClienteID.Value, nome_txt.Text, cpf_txt.Text);

                        MessageBox.Show("Cliente alterado com sucesso");
                        LimparCampos();
                        this.Close();
                    }
                    else
                    {
                        Cliente c = new Cliente();
                        c.Nome = nome_txt.Text;
                        c.CPF = cpf_txt.Text;


                        ClienteController.Salvar(c);

                        MessageBox.Show("Salvo com sucesso!");
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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();            
        }
    }
}
