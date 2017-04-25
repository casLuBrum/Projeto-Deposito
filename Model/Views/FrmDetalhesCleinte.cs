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
    public partial class FrmDetalhesCleinte : Form
    {
        public int ClienteID { get; set; }

        public FrmDetalhesCleinte(int ID)
        {
            InitializeComponent();

            ClienteController cliController = new ClienteController();
            Cliente cliente = cliController.Detalhes(ID);
            this.ClienteID = cliente.ClienteID;

            if (cliente != null)
            {
                lbl_Id.Text = cliente.ClienteID.ToString();
                lbl_Nome.Text = cliente.Nome;
                lbl_Cpf.Text = cliente.CPF;
                this.Show();
            }
            else
            {
                MessageBox.Show("Cliente não encontrado", "Erro");
                this.Close();
            }
        }

        

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            
            FrmCadastrarCliente cadCliente = new FrmCadastrarCliente(ClienteID);

            cadCliente.ShowDialog();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            ClienteController.Excluir(ClienteID);

            MessageBox.Show("Cliente excluido com sucesso !");

            this.Close();
        }
    }
}
