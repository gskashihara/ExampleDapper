using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Kashihara.DAO.Connection
{
    public class ConnectionFactory
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connSqlEsquire"].ConnectionString;
        static SqlConnection conn = new SqlConnection();

        public static SqlConnection GetSqlConnection()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            return conn;
        }

    }
}
