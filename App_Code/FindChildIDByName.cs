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
/// This class SRP class to find a childs id from database by their name given in the form.
/// author: Tanzila
/// </summary>
public class FindChildIDByName
{

    public static Child GetChildInfo(string fname, int pid)
    {
        try
        {
            Child C = new Child();

            SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");

            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection made\n");
                string q = "SELECT * FROM Child WHERE pid=" + pid + " AND fname LIKE '" + fname + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Select successful!");

                    C.Cid = Int32.Parse(reader.GetSqlValue(0).ToString());
                    Console.WriteLine(C.Cid);
                    C.FName = reader.GetString(1);
                    Console.WriteLine(C.FName);
                    C.LName = reader.GetString(2);
                    Console.WriteLine(C.LName);
                    C.Sex = reader.GetString(3);
                    Console.WriteLine(C.Sex);
                    C.DOB = reader.GetSqlValue(4).ToString();
                    Console.WriteLine(C.DOB);
                    C.SpecialNeed = reader.GetString(5);
                    Console.WriteLine(C.SpecialNeed);
                    C.Pid = Int32.Parse(reader.GetSqlValue(6).ToString());
                    Console.WriteLine(C.Pid);


                }
            }

            return C;
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



    public FindChildIDByName()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}