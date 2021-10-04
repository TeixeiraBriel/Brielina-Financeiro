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

namespace BrielinaFinanceiro
{
    /// <summary>
    /// Interação lógica para TabelaGastos.xam
    /// </summary>
    public partial class TabelaGastos : Page
    {
        private bool first = true;
        public TabelaGastos()
        {
            InitializeComponent();
        }

        private void CheckedBtnSim(object sender, RoutedEventArgs e)
        {
            if (first)
            {
                first = false;
                return;
            }
            if (Radio123.IsChecked == true)
            {
                TesteNome.Visibility = Visibility.Visible;
            }
            else
            {
                TesteNome.Visibility = Visibility.Collapsed;
            }
        }
    }
}
