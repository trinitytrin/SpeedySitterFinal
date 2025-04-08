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
/// Class to retrieve data about child of a person
/// Author Tanzila
/// </summary>
public class ChildInfoGetter
{
    public static Child[] GetChildInfo(Child[] c, int pid)
    {
        try
        {
            //Child[] c = new Child[0];

            SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");

            con.Open();

            int i = 0;

            if (con.State == System.Data.ConnectionState.Open)
            {
                //Console.WriteLine("Connection made\n");
                string q = "SELECT * FROM Child WHERE PId=" + pid + "";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   // Console.Write("Child Select successful!");
                    Array.Resize(ref c, c.Length + 1);

                    c[i] = new Child();

                    c[i].Cid = Int32.Parse(reader.GetSqlValue(0).ToString());
                    
                    c[i].FName = reader.GetString(1);
                    c[i].LName = reader.GetString(2);
                    
                     c[i].Sex = reader.GetString(3);
                    
                     c[i].DOB = reader.GetSqlValue(4).ToString();
      
                     c[i].SpecialNeed = reader.GetString(5);

                    c[i].Pid = Int32.Parse(reader.GetSqlValue(6).ToString());

                    i++;

                }
            }



            return c;
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
    public ChildInfoGetter()
    {
        //
        // TODO: Add constructor logic here
        //
    }





    public static Child GetChildInfoByID(int cid)
    {
        try
        {
            Child c = new Child();

            SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");

            con.Open();

            

            if (con.State == System.Data.ConnectionState.Open)
            {
                //Console.WriteLine("Connection made\n");
                string q = "SELECT * FROM Child WHERE cid=" + cid + "";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {


                    c.Cid = Int32.Parse(reader.GetSqlValue(0).ToString());

                    c.FName = reader.GetString(1);
                    c.LName = reader.GetString(2);

                    c.Sex = reader.GetString(3);

                    c.DOB = reader.GetSqlValue(4).ToString();

                    c.SpecialNeed = reader.GetString(5);

                    c.Pid = Int32.Parse(reader.GetSqlValue(6).ToString());

                   

                }
            }



            return c;
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

    public RequestFinder RequestFinder
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }
}