using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prince
{
    internal class db
    {
        public static string connectionString = "server=localhost; database = myshop; uid = root; pwd = \"\"; ";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        public static void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured trying to connect to the database!");
            }
        }


        public static void closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured trying to terminate database connection!");
            }
        }
    }
}
