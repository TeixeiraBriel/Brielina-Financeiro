using BrielinaFinanceiro.Entidades;
using RegistrosController;
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
    /// Interação lógica para CadastroDeGasto.xam
    /// </summary>
    public partial class CadastroDeGasto : Page
    {
        private bool firstA = true;
        private bool firstB = true;
        private bool firstC = true;
        private bool firstD = true;
        RegistrosComandos _registros;

        public CadastroDeGasto()
        {
            InitializeComponent();
            _registros = new RegistrosComandos();
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

        private void CadastrarGasto(object sender, RoutedEventArgs e)
        {
            Registro novoRegistro = new Registro();
            if (true)
            {

            }
            try
            {
                Aviso.Visibility = Visibility.Collapsed;
                novoRegistro.Descricao = txtDescricao.Text;
                novoRegistro.Valor = Double.Parse(txtValor.Text);
                if (DataDiferenteRadio.IsChecked == true)
                {
                    novoRegistro.Data = DateTime.Now.ToString("dd/MM/yyyy");
                }
                else
                {
                    novoRegistro.Data = txtDataInserido.Text;
                }
                novoRegistro.Grupo = txtGrupo.Text;
                novoRegistro.Credito = cartaoCreditoRadio.IsChecked == true ? 1 : 0;
                novoRegistro.Fixa = GastoFixoRadio.IsChecked == true ? 1 : 0;
                novoRegistro.DataVencimento = txtDataVencimento.Text;
                novoRegistro.Tipo = 1;

                if (string.IsNullOrEmpty(novoRegistro.Descricao) || novoRegistro.Valor == null)
                {
                    throw new Exception();
                }

                var resposta = _registros.cadastrarRegistro(novoRegistro);

                Aviso.Visibility = Visibility.Visible;
                Aviso.Foreground = Brushes.Green;
                Aviso.Text = "Registro cadastrado com sucesso";
            }
            catch
            {
                Aviso.Visibility = Visibility.Visible;
                Aviso.Foreground = Brushes.Red;
                Aviso.Text = "Não foi possivel realizar o cadastro, favor validar os campos.";
            }
        }
    }
}
