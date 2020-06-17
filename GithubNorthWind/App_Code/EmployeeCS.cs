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
public class EmployeeCS
{
   public SqlDataReader GetEmployees()
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "Get_Employee";
        connection.Open();
        SqlDataReader Reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        return Reader;
    }

    public SqlDataReader Chinook_GetEmployeeData()
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString);
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "Chinook_GetEmployeeData";
        connection.Open();
        SqlDataReader Reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        return Reader;
    }
}