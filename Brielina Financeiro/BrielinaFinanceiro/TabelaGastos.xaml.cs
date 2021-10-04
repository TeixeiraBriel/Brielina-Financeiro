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
        private bool firstA = true;
        private bool firstB = true;
        private bool firstC = true;
        private bool firstD = true;

        public TabelaGastos()
        {
            InitializeComponent();
        }

        private void DataDiferenteFunc(object sender, RoutedEventArgs e)
        {
            if (firstA)
            {
                firstA = false;
                return;
            }
            if (DataDiferenteRadio.IsChecked == true)
            {
                DataInseridoPanel.Visibility = Visibility.Collapsed;
            }
            else
            {
                DataInseridoPanel.Visibility = Visibility.Visible;
            }
        }

        private void GastoFixoRadioFunc(object sender, RoutedEventArgs e)
        {
            if (firstB)
            {
                firstB = false;
                return;
            }
            if (GastoFixoRadio.IsChecked == true)
            {
                gastoFixoPanel.Visibility = Visibility.Visible;
                DataVencimentoPanel.Visibility = Visibility.Visible;
            }
            else
            {
                gastoFixoPanel.Visibility = Visibility.Collapsed;
                DataVencimentoPanel.Visibility = Visibility.Collapsed;
            }

        }
    }
}
