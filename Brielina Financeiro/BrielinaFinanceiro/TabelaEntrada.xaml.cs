using BrielinaFinanceiro.Entidades;
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
    /// Interação lógica para TabelaEntrada.xam
    /// </summary>
    public partial class TabelaEntrada : Page
    {
        public TabelaEntrada()
        {
            InitializeComponent();
            registro x = new registro();

            x.Id = 6;
            x.Valor = 1.0;
            x.Data = "1996";
            x.Grupo = "Lendario";
            x.Credito = 1999;
            x.Tipo = 5;
            x.Descricao = "Biel é Chato";
            x.Fixa = 0;
            x.DataVencimento = "Vencida";

            registro y = new registro();

            y.Id = 6;
            y.Valor = 1.0;
            y.Data = "1997";
            y.Grupo = "Lendario";
            y.Credito = 1949;
            y.Tipo = 5;
            y.Descricao = " Chato";
            y.Fixa = 0;
            y.DataVencimento = "Vencida";

            DataGridEntrada.Items.Add(x);
            DataGridEntrada.Items.Add(y);
        }
    }
}
