/*Data Class for handling Address*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
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
/// Summary description for NewAddress : Persistent Class for object of Address in Database
/// </summary>
/// Written By Tanzila
public class NewAddress : IAddress
{
    private int id;
    private string street1;
    private string street2;
    private string city;
    private string state;
    private string zip;
    private int pid;
    double distance;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Street1
    {
        get { return street1; }
        set { street1 = value; }
    }

    public string Street2
    {
        get { return street2; }
        set { street2 = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string State
    {
        get { return state; }
        set { state = value; }
    }

    public string Zip
    {
        get { return zip; }
        set { zip = value; }
    }

     double lat;
     double lon;

    public  double Lat
    {
        get { return lat; }
        set { lat = value; }
    }
    public double Lon
    {
        get { return lon; }
        set { lon = value; }
    }

    public int Pid
    {
        get { return pid; }
        set { pid = value; }
    }

    public NewAddress()
    {
        //
        // TODO: Add constructor logic here
        lat = 0.0;
        lon = 0.0;
    }

    public  string GetFullAddress()
    {
        //this function converts the separated fields to complete address
        return null;
    }

    public void AddressToLatLon()
    {
        //this function will be called when converting an address to lat long and saving the lat long value to database
    }

    public NewAddress LatLonToAddress()
    {
        //this function will be called when converting the lat lon value to a particular address
        return null;
    }

    public Person SetAddress
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public double Distance
    {
        get { return distance; }
        set { distance = value; }
    }
    public void SaveAddressDB(int pid)
    {
        try
        {
            SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                NewAddress CurrentUserAddress = new NewAddress();
                
                CurrentUserAddress = PersonInfoGetter.GetPersonAddress(pid);

                if (CurrentUserAddress.Id>=1)

                {

                    string q = "UPDATE Address SET street_Address='" + this.Street1 + "', apt='" + this.Street2 + "', city='" + this.City + "', state='" + this.State + "', zip='" + this.Zip + "', latitude='" + this.Lat.ToString() + "', longitude='" + this.Lon.ToString() + "' WHERE pid="+pid+"";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();

                }
                else
                {
                    string q = "insert into Address(street_Address, apt, city, state, zip, latitude, longitude, pid)values('" + this.Street1 + "','" + this.Street2 + "','" + this.City + "','" + this.State + "','" + this.Zip + "','" + this.Lat.ToString() + "','" + this.Lon.ToString() + "', "+pid+")";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    //Response.Write("Data inserted successfully..!!");

                }

                con.Close();
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception caught in saving address to database ", e);
            Environment.Exit(0);

        }
        

    }

    public PersonInfoGetter GetsPersonAddress
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public DistanceCalculator DistanceCalculator
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