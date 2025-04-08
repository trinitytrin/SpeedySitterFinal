using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


//by Anitha
public partial class Logoutaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Remove("USER_NAME");
        Session.RemoveAll();
        Response.Redirect("Login.aspx");

    }
}