using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InsertArtistData : System.Web.UI.Page
{
 
        protected void Page_Load(object sender, EventArgs e)
        {
            PanelUserMessage.Visible = false;
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                ArtistsCS art = new ArtistsCS();
            art.InsertArtistData(TextBoxArtistName.Text);
                PanelFormInsert.Visible = false;
                PanelUserMessage.Visible = true;
            }
            catch (Exception ex)
            {
                LabelErrorMessage.Text = ex.Message.ToString();

            }

        }
    
}