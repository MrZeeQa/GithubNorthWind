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
/// Summary description for EmployeeCS
/// </summary>
public class ArtistsCS
{


    public void InsertArtistData(string ArtistName)
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString);
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "Chinook_InsertArtistData";
        SqlParameter ParamArtistName = new SqlParameter("@ArtistName",
        SqlDbType.NVarChar,40);
        ParamArtistName.Value = ArtistName;
        ParamArtistName.Direction = ParameterDirection.Input;
        command.Parameters.Add(ParamArtistName);
        

        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}