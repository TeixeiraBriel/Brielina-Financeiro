using RegistrosController;
using System.Collections.Generic;
using System.Windows.Controls;
using BrielinaFinanceiro.Entidades;

namespace BrielinaFinanceiro
{
    /// <summary>
    /// Interação lógica para TabelaEntrada.xam
    /// </summary>
    public partial class TabelaEntrada : Page
    {
        RegistrosComandos _registros;

        public TabelaEntrada()
        {
            InitializeComponent();
            _registros = new RegistrosComandos();

            List<Registro> registros = _registros.carregarRegistros();

            foreach (var registro in registros)
            {
                if (registro.Tipo == 0)
                {
                    DataGridEntrada.Items.Add(registro);
                }
            }
        }
    }
}
