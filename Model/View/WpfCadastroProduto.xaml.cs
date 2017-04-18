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
    public partial class WpfCadastroProduto : UserControl
    {
        public WpfCadastroProduto()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, RoutedEventArgs e)
        {            
            Produto prod = new Produto();
            if (ProdutoController.ValidarProd(Int32.Parse(cliente_txt.Text)))
            {
                prod.ClienteID.ClienteID = Int32.Parse(cliente_txt.Text);
                prod.Nome = nome_txt.Text;
                prod.Peso = Double.Parse(peso_txt.Text);
                prod.Quantidade = Int32.Parse(quant_txt.Text);
            }             
            
        }
    }
}
