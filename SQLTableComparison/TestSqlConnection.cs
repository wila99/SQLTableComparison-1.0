using System.Data.SqlClient;
using System.Linq;

namespace SQLTableComparison
{
    public class TestSqlConnection
    {
        SqlConnection connection;
        public TestSqlConnection(string sqlServerName, string sqlUsername, string sqlPassword, string sqlDatabase, string sqlTable)
        {
            if (new string[] { sqlServerName, sqlUsername, sqlPassword, sqlDatabase, sqlTable }.Contains("")) { }
            else {
                connection = new SqlConnection($"user id={sqlUsername};" +
                                      $"password={sqlPassword};" +
                                      $"server={sqlServerName};" +
                                     "Trusted_Connection=yes;" +
                                     $"database={sqlDatabase};" +
                                     "connection timeout=10");
            }
        }

        public bool TestConnectionCall()
        {
            //Attempt to open connection to the SQL server if unsucessful return error.
            try
            {
                if (connection == null)
                {
                    return false;
                }
                else
                {
                    connection.Open();
                    connection.Close();
                    return true;
                }
  
            }
            catch (SqlException)
            {
                return false;
            }

        }

    }
}
