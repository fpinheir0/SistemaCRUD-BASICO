using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WpfApp1.Banco
{
    internal class conexao
    {
        private static string host = "localhost";
        private static string port = "3306";
        private static string user = "root";
        private static string password = "root";
        private static string dbname = "db_crudluz";

        private static MySqlConnection connection;

        private static MySqlCommand command;

        public conexao()
        {
            try
            {
                connection = new MySqlConnection($"server={host};database={dbname};port={port};user={user};password={password};");
                connection.Open();
            } catch(Exception)
            {
                throw;
            }
        }

        public MySqlCommand Query()
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
            
                return command;
            }
            catch
            {
                throw;
            }
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
