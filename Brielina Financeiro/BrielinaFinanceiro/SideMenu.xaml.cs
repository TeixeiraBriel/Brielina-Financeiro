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
    /// Interação lógica para SideMenu.xam
    /// </summary>
    public partial class SideMenu : Page
    {
        private JanelaPrincipal janelaPrincipal;
        public SideMenu(JanelaPrincipal JanelaPrincipal)
        {
            InitializeComponent();
            janelaPrincipal = JanelaPrincipal;
        }

        private void Collapse(object sender, RoutedEventArgs e)
        {
            if (janelaPrincipal.sidebarMenuFrame.Visibility == Visibility.Hidden)
            {
                janelaPrincipal.sidebarMenuFrame.Visibility = Visibility.Visible;
                janelaPrincipal.CenterFrame.Margin = new Thickness(0, 0, 0, 0);
                janelaPrincipal.btnCollapse.Visibility = Visibility.Hidden;
            }
            else
            {
                janelaPrincipal.btnCollapse.Visibility = Visibility.Visible;
                janelaPrincipal.sidebarMenuFrame.Visibility = Visibility.Hidden;
                janelaPrincipal.CenterFrame.Margin = new Thickness(-150, 0, 0, 0);
            }
        }

        private void Cadastrar(object sender, RoutedEventArgs e)
        {

        }
    }
}
