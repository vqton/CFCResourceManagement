using System;
using Serilog;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public class SqlHelper
{
    string connectionString = "";
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
    public SqlHelper()
    {
        connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        
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
                
            }
            catch (Exception ex)
            {
                Logger.Debug(ex, "Error");
                
            }


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
                Logger.Debug(ex.Message);
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
                Logger.Debug(ex.Message);
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
                Logger.Debug(ex.Message);
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
