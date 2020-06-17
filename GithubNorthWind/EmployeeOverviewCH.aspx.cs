using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EmployeeOverviewCH : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadGridViewData();
        }
    }
    protected void LoadGridViewData()
    {
        EmployeeCS chmp = new EmployeeCS();
        GridViewEmployeeData.DataSource = chmp.Chinook_GetEmployeeData();
        GridViewEmployeeData.DataBind();
    }
}