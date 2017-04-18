using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Model;
using Controller;

namespace View
{
    /// <summary>
    /// Interação lógica para WpfCadastroCliente.xam
    /// </summary>
    public partial class WpfCadastroCliente : UserControl
    {
        public WpfCadastroCliente()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();

            c.Nome = nome_txt.Text;
            c.CPF = cpf_txt.Text;

            ClienteController.Salvar(c);
        }
    }
}
