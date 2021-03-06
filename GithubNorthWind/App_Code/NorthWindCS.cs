﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using Northwind.Components;

/// <summary>
/// Summary description for NorthWindCS
/// </summary>

    namespace Northwind.Components {

    public class NorthWindCS
    {
        public SqlDataReader GetCategories()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Northwind_GetCategories";
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return Reader;
        }

    }
}
