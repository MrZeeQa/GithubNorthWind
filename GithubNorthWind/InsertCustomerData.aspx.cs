using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using Northwind.Components;

public partial class InsertCustomerData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PanelUserMessage.Visible = false;
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            CustomerCS CustCH = new CustomerCS();
            CustCH.InsertCustomerData(TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxCompanyName.Text, TextBoxCity.Text);
            PanelFormInsert.Visible = false;
            PanelUserMessage.Visible = true;

        }
        catch (Exception ex)
        {

            LabelErrorMessage.Text = ex.Message.ToString();
        }
    }
}