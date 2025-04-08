using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

//Login Module : Change Password 
//Author: Anitha

public partial class ForgetPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=SUBBU\NAMED_INSTANCE;Initial Catalog=SpeedySitter;Integrated Security=True");
        con.Open();
        string checkuser = "select count(*) from Persons where FirstName='" + txtfirstname.Text.ToString() + "' and UserName ='" + txtusername.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, con);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        if (temp == 1)
        {
            string s = "Update Persons set Password='" + txtpassword.Text + "' where Firstname = '" + txtfirstname.Text + "' and UserName='" + txtusername.Text + "'";
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Login.aspx");
        }
        else
        {
            Response.Write("Invalid Details");
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}