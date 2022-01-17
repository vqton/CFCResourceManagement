using System;
using System.Configuration;
using System.Data.SqlClient;

public class SqlHelper
{
    string connectionString = "";

    public SqlHelper()
    {
        connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
    }

    public void ExecNonQuery(string queryString
      )
    {
        using (SqlConnection connection = new SqlConnection(
                   connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public SqlDataReader ExecReader(string queryString)
    {
        using (SqlConnection connection = new SqlConnection(
                   connectionString))
        {
            connection.Open();

            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
    }


    public object ExecScalar(string queryString, string newName)
    {
        object result = null;

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand(queryString, conn);

            try
            {
                conn.Open();
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return result;
    }
}