using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

//Code to save request to database 

// Author : Tanzila 

public partial class CreateRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            int current_pid = 3;
            int r_cid; 



            SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                //string q = "insert into Request(street_Address, apt, city, state, zip, latitude, longitude)values('" + this.Street1 + "','" + this.Street2 + "','" + this.City + "','" + this.State + "','" + this.Zip + "','" + this.Lat.ToString() + "','" + this.Lon.ToString() + "')";
                //SqlCommand cmd = new SqlCommand(q, con);
               // cmd.ExecuteNonQuery();
                //Response.Write("Data inserted successfully..!!");

                con.Close();
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