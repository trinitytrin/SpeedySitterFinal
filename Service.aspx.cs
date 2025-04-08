using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.WebControls.Expressions;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Windows; 

public partial class Service : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("GeocodeAddress.cshtml");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowResultAddress.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string session_user = Session["USER_NAME"].ToString();

        Person CurrenntUser = new Person();
        string s = "BabySitter";
        
        CurrenntUser = PersonInfoGetter.GetPersonInfoByUsername(session_user);

        if(CurrenntUser.Type!=s)
        {
            Response.Redirect("CreateNewRequest.cshtml");
        }
        else
        {
            Response.Redirect("FindRequest.cshtml");
        }
      

    }
}