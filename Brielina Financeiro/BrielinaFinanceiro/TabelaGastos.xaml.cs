using RegistrosController;
using System.Collections.Generic;
using System.Windows.Controls;
using BrielinaFinanceiro.Entidades;

namespace BrielinaFinanceiro
{
    /// <summary>
    /// Interação lógica para TabelaGastos.xam
    /// </summary>
    public partial class TabelaGastos : Page
    {
        RegistrosComandos _registros;

        public TabelaGastos()
        {
            InitializeComponent();
            _registros = new RegistrosComandos();

            List<Registro> registros = _registros.carregarRegistros();

            foreach (var registro in registros)
            {
                if (registro.Tipo == 1)
                {
                    DataGridEntrada.Items.Add(registro);
                }
            }
        }
    }
}
