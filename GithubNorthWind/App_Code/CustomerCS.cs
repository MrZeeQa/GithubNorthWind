using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Text;
using Northwind.Components;
using System.Reflection;

/// <summary>
/// Summary description for CustomerCS
/// </summary>
public class CustomerCS
{
   public SqlDataReader GetCustomerData()
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString);
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "Chinook_GetCustomerData";
        connection.Open();
        SqlDataReader Reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        return Reader;
    }

    public void InsertCustomerData(string FirstName, string LastName, string Company, string City)
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString);
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "Chinook_InsertCustomerData";
        SqlParameter ParamFirstName = new SqlParameter("@FirstName",
        SqlDbType.NVarChar, 40);
        ParamFirstName.Value = FirstName;
        ParamFirstName.Direction = ParameterDirection.Input;
        command.Parameters.Add(ParamFirstName);
        SqlParameter ParamLastName = new SqlParameter("@LastName", SqlDbType.NVarChar, 20);
        ParamLastName.Value = LastName;
        ParamLastName.Direction = ParameterDirection.Input;
        command.Parameters.Add(ParamLastName);
        SqlParameter ParamCompany = new SqlParameter("@Company", SqlDbType.NVarChar, 80);
        ParamCompany.Value = Company;
        ParamCompany.Direction = ParameterDirection.Input;
        command.Parameters.Add(ParamCompany);
        SqlParameter ParamCity = new SqlParameter("@City", SqlDbType.NVarChar, 40);
        ParamCity.Value = City;
        ParamCity.Direction = ParameterDirection.Input;
        command.Parameters.Add(ParamCity);


        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}