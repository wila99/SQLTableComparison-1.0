using System.Data;
using System.Data.SqlClient;


namespace SQLTableComparison
{
    class Retrieve
    {
        public DataSet dataSet = new DataSet();
        public DataSet QueryTable(Connection conn)
        {
            if (dataSet != null)
            {
                dataSet.Clear();
            }

            string dataQuery = $"SELECT * FROM {conn.Table}";

            SqlCommand sqlCommand = new SqlCommand(dataQuery, conn.connection);
            conn.connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataSet);
            conn.connection.Close();
            sqlDataAdapter.Dispose();

            return dataSet;
        }
    }
}
