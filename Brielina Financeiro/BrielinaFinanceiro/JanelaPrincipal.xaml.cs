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
    public partial class JanelaPrincipal : Window
    {
        private bool collapsed = true;
        private SideMenu menu;

        public JanelaPrincipal()
        {
            InitializeComponent();
            menu = new SideMenu(this);

            this.sidebarMenuFrame.NavigationService.Navigate(menu);
        }

        private void FecharApp(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MoverTela(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Collapse(object sender, MouseButtonEventArgs e)
        {
            if (sidebarMenuFrame.Visibility == Visibility.Hidden)
            {
                sidebarMenuFrame.Visibility = Visibility.Visible;
                CenterFrame.Margin = new Thickness(0, 0, 0, 0);
                btnCollapse.Visibility = Visibility.Hidden;
            }
            else
            {
                btnCollapse.Visibility = Visibility.Visible;
                sidebarMenuFrame.Visibility = Visibility.Hidden;
                CenterFrame.Margin = new Thickness(-150, 0, 0, 0);
            }
        }

        private void Inicio(object sender, MouseButtonEventArgs e)
        {
            CenterFrame.Source = new Uri("Inicio.xaml", UriKind.Relative);
        }

        private void CadastroDeGasto(object sender, MouseButtonEventArgs e)
        {
            CenterFrame.Source = new Uri("CadastroDeGasto.xaml", UriKind.Relative);
        }
        private void CadastroEntrada(object sender, MouseButtonEventArgs e)
        {
            CenterFrame.Source = new Uri("CadastroEntrada.xaml", UriKind.Relative);
        }
        private void TababelaEntrada(object sender, MouseButtonEventArgs e)
        {
            CenterFrame.Source = new Uri("TabelaEntrada.xaml", UriKind.Relative);
        }
        private void TabelaGastos(object sender, MouseButtonEventArgs e)
        {
            CenterFrame.Source = new Uri("TabelaGastos.xaml", UriKind.Relative);
        }
    }
}
