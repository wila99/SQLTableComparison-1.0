using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLTableComparison
{
    public class TestSqlConnection
    {
        SqlConnection connection;
        public TestSqlConnection(string sqlServerName, string sqlUsername, string sqlPassword, string sqlDatabase, string sqlTable)
        {
            connection = new SqlConnection("user id=" + sqlUsername + ";" +
                                        "password=" + sqlPassword + ";" +
                                        "server=" + sqlServerName + ";" +
                                       "Trusted_Connection=yes;" +
                                       "database=" + sqlDatabase + ";" +
                                       "connection timeout=10");
        }

        public bool TestConnectionCall()
        {
            //Attempt to open connection to the SQL server if unsucessful return error.
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }

        }

    }
}
