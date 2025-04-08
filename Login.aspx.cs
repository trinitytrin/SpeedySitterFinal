using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


//Log in Module
//Author: Anitha

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtname.Focus();
    }
    protected void btnregister_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserInfoRegistration.aspx");
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {

        string username1 = txtname.Text;
        Session["Username1"] = username1.ToString();
        SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");
        con.Open();
        string checkuser = "select count(*) from Persons where UserName='" + txtname.Text.ToString() + "' and Password ='"+txtpassword.Text+"'" ;
        SqlCommand com = new SqlCommand(checkuser, con);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        if (temp == 1)
        {
            Session["USER_NAME"] = txtname.Text.ToString();

            Response.Redirect("NewHome.aspx");
        }
        else
        {
            Response.Write("Invalid Details");
        }
    }
    protected void btnforget_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        Response.Redirect("ForgetPassword.aspx");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
    }
}