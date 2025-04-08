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
/// This Class gets all the address from database to sort them according to the given address and their distances
/// author: Tanzila
/// </summary>
public class GetDBAddress
{

    public void GetAddressFromDB()
        {
            try
            {
                int size = 0;
                int[] id = new int[0];
                double[] lat = new double[0];
                double[] lon = new double[0];
                double[] distance = new double[0];
                NewAddress[] ad = new NewAddress[0];


                int i = 0;


                SqlConnection con = new SqlConnection(@"Data Source=DAMONNAHARIS\TRINA;Initial Catalog=TestDB1;Integrated Security=True");

                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "SELECT * FROM Address";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Array.Resize(ref lat, lat.Length + 1);
                        Array.Resize(ref lon, lon.Length + 1);
                        Array.Resize(ref id, id.Length + 1);
                        Array.Resize(ref distance, distance.Length + 1);
                        Array.Resize(ref ad, ad.Length + 1);

                        ad[i] = new NewAddress();
                        string aid = reader.GetSqlValue(0).ToString();
                        //Console.WriteLine(aid);
                        id[i] = Int32.Parse(aid);

                        lat[i] = Double.Parse(reader.GetString(6));

                        lon[i] = Double.Parse(reader.GetString(7));

                        ad[i].Id = id[i];
                        ad[i].Lat = lat[i];
                        ad[i].Lon = lon[i];
                    ad[i].Street1 = reader.GetString(1);
                    ad[i].Street2 = reader.GetString(2);
                    ad[i].City = reader.GetString(3);
                    ad[i].State = reader.GetString(4);
                    ad[i].Zip = reader.GetString(5);
                    ad[i].Pid = Int32.Parse(reader.GetSqlValue(8).ToString());
                    // lon2[i] = Double.Parse(slongitude);
                    //lon[i]=Double.Parse()
                    //street = reader.GetString(1);
                    //lat[i] = Double.Parse(reader.GetString(reader.GetOrdinal("latitude")));
                    //lon[i] = Double.Parse(reader.GetString(reader.GetOrdinal("longitude")));

                    //string street = reader.GetString(1);
                    // Console.WriteLine(street);
                    i++;
                        //Console.WriteLine("Query successful..!! \n Lat: " + lat + " Lon: " + lon);
                        //Console.WriteLine("Query successful..!!");

                    }

                    size = lat.Length;

                   /* for (int j = 0; j < size; j++)
                    {
                        Console.WriteLine("Aid: {0}, Latitude: {1}, Longitude: {2}", id[j], lat[j], lon[j]);
                    }*/

                    con.Close();
                }
                double glat = 30.0961375;
                double glon = -96.0037208;

                for (int j = 0; j < size; j++)
                {
                    distance[j] = DistanceCalculator.CalculateDistance(glat, glon, lat[j], lon[j]);
                    ad[j].Distance = distance[j];
                   // Console.WriteLine ("Distance is: {0} Km", distance[j]);
                }

                AddressSorter.SortAddress(ad, size);
                Console.WriteLine("After Sorting the addresses: ");
                for (int j = 0; j < size; j++)
                {

                    Console.WriteLine("Distance is: {0} Km, with Aid: {1}", ad[j].Distance, ad[j].Id);
                }



            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to terminate..");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    
    public GetDBAddress()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}