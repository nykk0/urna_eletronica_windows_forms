using MySql.Data.MySqlClient;
using System.Data;

namespace Urna_eletronica
{
    internal class conexao
    {
        private MySqlConnection Conexao;

        public void conectarBD()
        {
            Conexao = new MySqlConnection("persist security info = false;" +
                                          "server=localhost;" +
                                          "database=urna_eletronica;" +
                                          "uid=root;" +
                                          "pwd=;SslMode=none ");
            Conexao.Open();
        }

        public void AlterarTabelas(string sql)
        {
            conectarBD();
            MySqlCommand comandos = new MySqlCommand(sql, Conexao);
            comandos.ExecuteNonQuery();
            Conexao.Close();

        }
        public DataTable ConsultarTabelas(string sql)
        {
            conectarBD();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, Conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            Conexao.Close();
            return resultado;
        }
    }
}
