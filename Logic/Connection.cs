using System.Data.SqlClient;
using System.Data;

namespace SQLTableComparison
{
    public class Connection
    {
        public SqlConnection connection;
        public string Database { get; set; }
        public string Server { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Table { get; set; }

        public Connection()
        {

        }

        public void SetConnection()
        {
            connection = new SqlConnection($"user id={Username};" +
                                        $"password={Password};" +
                                        $"server={Server};" +
                                       "Trusted_Connection=yes;" +
                                       $"database={Database};" +
                                       "connection timeout=10");
        }

        public bool TestConnection()
        {
            //Attempts to open connection to the database.
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

