using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQLTableComparison
{
    public class CompareTables
    {
        //Variables
        string serverName;
        string Username;
        string Password;
        string Database;
        string Table;
        SqlConnection compareConnection;
        public DataTable dataTable = new DataTable();



        public CompareTables(string serverName, string Username, string Password, string Database, string table) {

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

        void QueryTable() {

            string dataQuery = "SELECT * FROM "+Table;
            
            SqlCommand sqlCommand = new SqlCommand(dataQuery, compareConnection);
            compareConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            compareConnection.Close();
            sqlDataAdapter.Dispose();


        }
    }
}
