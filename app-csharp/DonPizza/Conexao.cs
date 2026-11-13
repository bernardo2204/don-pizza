using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DonPizza
{
    internal class Conexao
    {
        MySqlConnection conn;

        private void Conectar()
        {
            string dadosConexao = "Persist security info = false; server = localhost; database = DB_Delivery; uid = root; pwd=SENHA_AQUI;";
            try
            {
                conn = new MySqlConnection(dadosConexao);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception($"A conexão não foi estabelecida.\n{ex.Message}");
            }
        }

        public void ExecutarComando(string sql)
        {
            Conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Instrução não executada.\n{sql}\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable ExecutarConsulta(string query)
        {
            Conectar();
            try
            {
                MySqlDataAdapter dados = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Instrução SELECT com erro.\n{query}\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
