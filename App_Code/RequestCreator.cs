using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
/// <summary>
/// This class SRP class to save the new request to Database.
/// author: Tanzila
/// </summary>
public class RequestCreator
{
    public RequestCreator()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static bool SaveRequestDB(Request R)
    {
        try
        {
            SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Request(rdate, startTime, endTime, comments, pid, cid)values('" + R.RDate + "','" + R.StartTime + "','" + R.EndTime + "','" + R.Comments + "','" + R.Pid + "','" + R.Cid + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                //Response.Write("Data inserted successfully..!!");

                con.Close();
                return true;
            }
            else
                return false;
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception caught in saving address to database ", e);
            Environment.Exit(0);
            return false;

        }


    }
}