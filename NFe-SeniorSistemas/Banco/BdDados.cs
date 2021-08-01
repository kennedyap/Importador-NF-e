using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFe_SeniorSistemas.Banco
{
    public class BdDados
    {
        private static DataTable Select(string query)
        {
            SqlConnection newConnection = new SqlConnection(Properties.Settings.Default.NfeSeniorConnectionString);
            SqlDataAdapter newDp = new SqlDataAdapter(query, newConnection);
            DataTable newTable = new DataTable();
            newDp.Fill(newTable);
            newConnection.Close();

            return newTable;
        }

        private static void InsertOrUpdate(string query)
        {
            SqlConnection newConnection = new SqlConnection(Properties.Settings.Default.NfeSeniorConnectionString);
            SqlCommand comando = new SqlCommand(query, newConnection);

            newConnection.Open();
            comando.ExecuteNonQuery();
            newConnection.Close();
        }

        public static DataTable SelectEmailRecuperacao(string login)
        {
            string query = "SELECT Email FROM usuario WHERE UserName like '%" + login + "%'";
            return Select(query);
        }

        public static DataTable SelectUsuarioLogin(string login, string senha)
        {
            string query = "SELECT * FROM usuario WHERE UserName = '" + login + "' AND Password = '" + senha + "'";
            return Select(query);
        }

        public static void InsertUsuario(string login, string senha, string email)
        {
            string query = "INSERT INTO usuario (Username, Password, Email) VALUES ('" + login + "', '" + senha + "', '" + email + "')";
            InsertOrUpdate(query);
        }

        public static void UpdateUsuario(string login, string senha)
        {
            string query = "UPDATE usuario SET Password = '" + senha + "' WHERE UserName = '" + login + "'";
            InsertOrUpdate(query);
        }
    }
}
