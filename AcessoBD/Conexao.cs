using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoBD
{
    public class Conexao
    {
        MySqlConnection conn;
        static string servidor = "localhost";
        static string banco = "bd_aula";
        static string senha = "cursoads";
        static string usuario = "root";
        static string strCon = $"server={servidor}; user id={usuario}; database={banco}; pwd={senha}";

        private void Conectar()
        {
            try
            {
                conn = new MySqlConnection(strCon);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Desconectar()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public bool Executa(string sql)
        {
            bool resultado;
            try
            {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                Desconectar();
            }
            return resultado;
        }

        public DataTable Retorna(string sql)
        {
            try
            {
                Conectar();
                DataTable dados = new DataTable();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand = cmd;
                da.Fill(dados);
                return dados;
            }
            catch
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
    }



}
