using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Data.SqlClient;

/// <summary>
/// RequestFinder is SRP class that has the method to find all the requests that match date or time of a given request search
/// Author: Tanzila
public class RequestFinder
{
    public RequestFinder()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static Request[] SearchRequest(Request demoreq, Request[] R)
    {
        try
        {
             

            int i = 0;
           // R = new Request[0];

            SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");

            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("connected!");
                string q = "SELECT * FROM Request WHERE rdate='"+demoreq.RDate+"'";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("Request Select successful!");
                    Array.Resize(ref R, R.Length + 1);

                    R[i] = new Request();

                    R[i].Rid = Int32.Parse(reader.GetSqlValue(0).ToString());
                    R[i].RDate = reader.GetSqlValue(1).ToString();
                    R[i].StartTime = reader.GetSqlValue(2).ToString();
                    R[i].EndTime = reader.GetSqlValue(3).ToString();
                    R[i].Comments = reader.GetSqlValue(4).ToString();
                    R[i].Pid = Int32.Parse(reader.GetSqlValue(5).ToString());
                    R[i].Cid = Int32.Parse(reader.GetSqlValue(6).ToString());

                    i++;

                }



                return R;
            }
            else
                return null;

        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Press any key to terminate..");
            Console.ReadKey();
            Environment.Exit(0);
            return null;
        }
    }
}