using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Configuration;
using BrielinaFinanceiro.Entidades;
using System.Data.SQLite;

namespace RegistrosController
{
    public class RegistrosComandos
    {
        private ConnectionString connectionString = new ConnectionString();

        public List<Registro> carregarRegistros()
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionString.carregarConnectionString(), true))
            {
                var saida = cnn.Query<Registro>("select * from Registros", new DynamicParameters());
                return saida.ToList();
            }
        }

        public Registro carregarRegistroEspecifico(string id)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionString.carregarConnectionString(), true))
            {
                var saida = cnn.Query<Registro>("select * from Registros where Id='" + id + "'", new DynamicParameters()).FirstOrDefault();
                return saida;
            }
        }

        public string cadastrarRegistro(Registro registro)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionString.carregarConnectionString(), true))
            {
                var saida = cnn.Query<int>("select Id from Registros order by Id desc  LIMIT 1", new DynamicParameters()).FirstOrDefault();
                registro.Id = saida + 1;
                cnn.Execute("insert into Registros" +
                            "(Valor," +
                            "Data," +
                            "Grupo," +
                            "Credito," +
                            "Tipo," +
                            "Descricao," +
                            "Fixa," +
                            "DataVencimento) values (" +
                            "@Valor," +
                            "@Data," +
                            "@Grupo," +
                            "@Credito," +
                            "@Tipo," +
                            "@Descricao," +
                            "@Fixa," +
                            "@DataVencimento" +
                            ")"
                            , registro);

                return "Gerado com o ID: " + registro.Id;
            }
        }

        public dynamic modificarRegistro(Registro registro, string id)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionString.carregarConnectionString(), true))
            {
                cnn.Execute("UPDATE Registros " +
                    "SET Valor = @Valor," +
                    "Data = @Data," +
                    "Grupo = @Grupo," +
                    "Credito = @Credito," +
                    "Tipo = @Link," +
                    "Descricao = @Descricao," +
                    "Fixa = @Fixa," +
                    "DataVencimento = @DataVencimento," +
                    " WHERE Id='" + id + "'", registro);
            }

            return registro;
        }

        public string apagarRegistroEspecifico(string id)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionString.carregarConnectionString(), true))
            {
                var saida = cnn.Execute("delete from Registros where Id='" + id + "'", new DynamicParameters());
                if (saida == 0)
                {
                    return "not found";
                }
                else
                {
                    return "success";
                }
            }
        }
    }

    public class ConnectionString
    {
        public string carregarConnectionString(string id = "Default")
        {
            var path = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

            var caminho = ConfigurationManager.ConnectionStrings[id].ConnectionString;

            path = path.Replace("file:\\", "");

            caminho = caminho.Replace("|Diretorio|", path);

            return caminho;
        }

        public string carregarConnectionStringFinanceiro(string id = "Financeiro")
        {
            var path = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

            var caminho = ConfigurationManager.ConnectionStrings[id].ConnectionString;

            path = path.Replace("file:\\", "");

            caminho = caminho.Replace("|Diretorio|", path);

            return caminho;
        }
    }
}
