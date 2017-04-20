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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Nome = nome_txt.Text;
            c.CPF = cpf_txt.Text;

            ClienteController.Salvar(c);

            MessageBox.Show("Salvo com sucesso!");
        }
    }
}
