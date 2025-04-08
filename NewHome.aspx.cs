using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string session_user = Session["USER_NAME"].ToString();

            if(session_user=="")
            {
                Response.Redirect("Login.aspx");
            }

        }
        catch (Exception ex)
        {
            this.Session["exceptionMessage"] = ex.Message;
            //Response.Redirect("ErrorDisplay.aspx");
            Response.Write(ex.Message + ex.StackTrace);

        }
    }
}