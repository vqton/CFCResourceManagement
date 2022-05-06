using System;
using Serilog;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public class SqlHelper
{
    string connectionString = "";

    public SqlHelper()
    {
        connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        Log.Information(connectionString);
    }

    public void ExecNonQuery(string queryString)
    {
        using (SqlConnection connection = new SqlConnection(
                   connectionString))
        {
            int iResult;
            try
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                iResult = command.ExecuteNonQuery();
                Log.Information("Records affected: " + iResult.ToString("N0"));
            }
            catch (Exception ex)
            {

                Log.Error(ex.Message);
                Log.Debug(queryString);
            }


        }
    }

    public SqlDataReader ExecReader(string queryString)
    {
        using (SqlConnection connection = new SqlConnection(
                   connectionString))
        {
            connection.Open();
            Log.Information(connection.State.ToString());
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            Log.Information(queryString);

            return reader;
        }
    }

    public DataTable GetData(string sQuery)
    {
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();

        using (SqlConnection connection = new SqlConnection(
                 connectionString))
        {
            try
            {
                connection.Open();
                adapter = new SqlDataAdapter(sQuery, connection);
                adapter.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                Log.Debug(ex.Message);
            }

        }

        return null;
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

    public object ExecScalar(string queryString)
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

    public static DataSet SelectSqlRows(string connectionString,
    string queryString, string tableName)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(queryString, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            connection.Open();

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, tableName);

            //code to modify data in DataSet here

            builder.GetUpdateCommand();

            //Without the SqlCommandBuilder this line would fail
            adapter.Update(dataSet, tableName);
            
            return dataSet;
        }
    }
}
