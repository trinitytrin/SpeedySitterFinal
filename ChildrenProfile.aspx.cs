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
//using System.Windows.Forms;
using System.Data.SqlClient;

public partial class ChildrenProfile : System.Web.UI.Page
{
    
    SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
      //  Response.Write("Hi!");
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        
        con.Open();

        if (con.State == System.Data.ConnectionState.Open)
        {
            string q = "insert into UserInfo(id, fName)values('" + TxtID.Text.ToString() + "','" + TxtName.Text.ToString() + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            //Response.Write("Data inserted successfully..!!");

            con.Close();
        }

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}