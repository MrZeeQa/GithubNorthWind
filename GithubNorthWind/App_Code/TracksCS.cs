using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using Northwind.Components;

/// <summary>
/// Summary description for TracksCS
/// </summary>
public class TracksCS
{
    public SqlDataReader GetTrackData()
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString);
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "Chinook_GetTrackData";
        connection.Open();
        SqlDataReader Reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        return Reader;
    }
}