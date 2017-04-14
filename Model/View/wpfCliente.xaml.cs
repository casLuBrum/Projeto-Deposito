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
    /// Interação lógica para wpfCliente.xam
    /// </summary>
    public partial class wpfCliente : UserControl
    {
        public wpfCliente()
        {
            InitializeComponent();
        }

        private void Salvar(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.Nome = Nome_text;
            c.CPF = Cpf_text;

            ClienteController.Salvar(c);
        }
    }
}
