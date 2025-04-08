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
/// This class is for get information of a person given the pid
/// author: Anitha, Ashvija, Tanzila
/// </summary>
public class PersonInfoGetter
{
    public GetDBAddress GetsPersonsInfoAddress
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
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

    public static Person GetPersonInfo(int pid)
    {
        try
        {
            Person p = new Person();

            SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");

            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection made\n");
                string q = "SELECT * FROM Persons WHERE PId=" + pid + "";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Select successful!");

                    p.Pid = Int32.Parse(reader.GetSqlValue(0).ToString());
                    Console.WriteLine(p.Pid);
                    p.FName = reader.GetString(2);
                    p.LName = reader.GetString(1);
                    Console.WriteLine(p.FName + " " + p.LName);
                    p.Sex = reader.GetString(3);
                    Console.WriteLine(p.Sex);
                    p.VisaStatus = reader.GetString(5);
                    Console.WriteLine(p.VisaStatus);
                    p.Type = reader.GetSqlValue(6).ToString();
                    Console.WriteLine(p.Type);
                    p.Phone = reader.GetString(7);
                    p.Email = reader.GetString(8);
                    p.UserName = reader.GetString(9);
                    p.Password = reader.GetString(10);
                    Console.WriteLine(p.Phone + " " + p.Email);


                }
            }

            return p;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Press any key to terminate..");
            Console.ReadKey();
            Environment.Exit(0);
            return null;
        }

    }

    public static Person GetPersonInfoByUsername(string uname)
    {
        try
        {
            Person p = new Person();

            SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");

            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection made\n");
                string q = "SELECT * FROM Persons WHERE UserName='" + uname + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Select successful!");

                    p.Pid = Int32.Parse(reader.GetSqlValue(0).ToString());
                    Console.WriteLine(p.Pid);
                    p.FName = reader.GetString(2);
                    p.LName = reader.GetString(1);
                    Console.WriteLine(p.FName + " " + p.LName);
                    p.Sex = reader.GetString(3);
                    Console.WriteLine(p.Sex);
                    p.VisaStatus = reader.GetString(5);
                    Console.WriteLine(p.VisaStatus);
                    p.Type = reader.GetSqlValue(6).ToString();
                    Console.WriteLine(p.Type);
                    p.Phone = reader.GetString(7);
                    p.Email = reader.GetString(8);
                    p.UserName = reader.GetString(9);
                    p.Password = reader.GetString(10);
                    Console.WriteLine(p.Phone + " " + p.Email);


                }
            }

            return p;
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

    public static NewAddress GetPersonAddress(int pid)
    {
        try
        {
            NewAddress UserAddress = new NewAddress();


            SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");

            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection made\n");
                string q = "SELECT * FROM Address WHERE PId=" + pid + "";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {


                    UserAddress.Id = Int32.Parse(reader.GetSqlValue(0).ToString());
                    UserAddress.Lat = Double.Parse(reader.GetString(6));
                    UserAddress.Lon = Double.Parse(reader.GetString(7));
                    UserAddress.Street1 = reader.GetString(1);
                    UserAddress.Street2 = reader.GetString(2);
                    UserAddress.City = reader.GetString(3);
                    UserAddress.State = reader.GetString(4);
                    UserAddress.Zip = reader.GetString(5);
                    UserAddress.Pid = Int32.Parse(reader.GetSqlValue(8).ToString());


                }
            }



            return UserAddress;

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


    public PersonInfoGetter()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}