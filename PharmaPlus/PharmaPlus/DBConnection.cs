using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PharmaPlus
{
    class DBConnection
    {
        private SqlConnection connection;
        public string conStr;
        private static DBConnection Instance;
        private DBConnection()
        {

        }
        public static DBConnection getInstance()
        {
            if (Instance == null)
            {
                Instance = new DBConnection();
            }
            return Instance;
        }
        public SqlConnection getConnection()
        {
            connection = new SqlConnection(conStr);

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;

        }

        public int executeQuery(string query)
        {
            connection = getConnection();
            SqlCommand cmd = new SqlCommand(query, connection);

            int rows = cmd.ExecuteNonQuery();
            return rows;

        }
        public SqlDataAdapter getData(string query)
        {

            SqlDataAdapter data = new SqlDataAdapter(query, getConnection());
            return data;
        }
        public void closeConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }
}
