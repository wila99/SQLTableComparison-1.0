using System.Data.SqlClient;
using System.Data;

namespace SQLTableComparison
{
    public class GetSQLTable
    {
        //Variables
        string serverName;
        string Username;
        string Password;
        string Database;
        string Table;
        SqlConnection compareConnection;
        public DataSet dataSet = new DataSet();

        public GetSQLTable(string serverName, string Username, string Password, string Database, string table)
        {
            this.serverName = serverName;
            this.Username = Username;
            this.Password = Password;
            this.Database = Database;
            this.Table = table;

            SetConnection();
        }

        void SetConnection()
        {
            compareConnection = new SqlConnection("user id=" + Username + ";" +
                                        "password=" + Password + ";" +
                                        "server=" + serverName + ";" +
                                       "Trusted_Connection=yes;" +
                                       "database=" + Database + ";" +
                                       "connection timeout=30");
            QueryTable();
        }

        void QueryTable()
        {

            string dataQuery = "SELECT * FROM " + Table;

            SqlCommand sqlCommand = new SqlCommand(dataQuery, compareConnection);
            compareConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataSet);
            compareConnection.Close();
            sqlDataAdapter.Dispose();


        }
        public DataSet GetData() {
            return dataSet;
        }
    }
}

