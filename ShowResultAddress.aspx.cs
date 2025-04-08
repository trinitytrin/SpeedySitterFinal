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


//This one shows the found results of nearby addresses based on given address
//author: Tanzila

public partial class ShowResultAddress : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string session_user = Session["USER_NAME"].ToString();


            Person CurrenntUser = new Person();
            NewAddress CurrentUserAddress = new NewAddress();
            CurrenntUser = PersonInfoGetter.GetPersonInfoByUsername(session_user);
            CurrentUserAddress = PersonInfoGetter.GetPersonAddress(CurrenntUser.Pid);

            Response.Write("<H2>Showing Results for Nearby Address Query<H3>"+"<BR>");
            Response.Write("For User: " + CurrenntUser.FName+" " +CurrenntUser.LName+"<BR>");
            Response.Write("For Address: " + CurrentUserAddress.Street1+ ", " +CurrentUserAddress.City+", " +CurrentUserAddress.State+ " "+ CurrentUserAddress.Zip+"<BR>");

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
                //Response.Write("DB connect successful!\n");
               string q = "SELECT * FROM Address";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Response.Write("Select Query Successful!\n");
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
                    ad[i].Pid = Int32.Parse(reader.GetValue(8).ToString());

                    i++;

                }

                size = lat.Length;



                con.Close();
            }
            double glat = CurrentUserAddress.Lat;
            double glon = CurrentUserAddress.Lon;

            for (int j = 0; j < size; j++)
            {
                distance[j] = DistanceCalculator.CalculateDistance(glat, glon, lat[j], lon[j]);
                ad[j].Distance = distance[j];
                // Console.WriteLine ("Distance is: {0} Km", distance[j]);
            }

            AddressSorter.SortAddress(ad, size);
           // Response.Write("After Sorting the addresses: ");
            for (int j = 0; j < size; j++)
            {
                if (ad[j].Pid != CurrenntUser.Pid)
                {
                   

                    Person p = PersonInfoGetter.GetPersonInfo(ad[j].Pid);

                    if (p.Type != CurrenntUser.Type)
                    {
                        Response.Write("-------------------------------------------" + "<BR>");
                        Response.Write("<H3>Distance is: " + ad[j].Distance + " Km,  with Aid: " + ad[j].Id + "</H3><BR>");
                        Response.Write("Street: " + ad[j].Street1 + ", Apt/Unit: " + ad[j].Street2 + "<BR>");
                        Response.Write("City: " + ad[j].City + ", State: " + ad[j].State + " Zip: " + ad[j].Zip + "<BR>" + "<BR>");

                        // Person p = PersonInfoGetter.GetPersonInfo(ad[j].Pid);
                        Response.Write("Address Of: " + p.FName + "  " + p.LName + "<BR>");
                        Response.Write("Sex: " + p.Sex + ", User Type: " + p.Type + ", Visa Status: " + p.VisaStatus + "<BR>");
                        Response.Write("Phone: " + p.Phone + ", Email: " + p.Email + "<BR>" + "<BR>");


                        Child[] C = new Child[0];
                        C = ChildInfoGetter.GetChildInfo(C, p.Pid);

                        if (C.Length > 0)
                        {


                            for (int k = 0; k < C.Length; k++)
                            {
                                Response.Write("Child " + (k + 1) + " : " + C[k].FName + " " + C[k].LName + "<BR>");
                                Response.Write("Sex: " + C[k].Sex + ", Date of Birth: " + C[k].DOB + "<BR>");
                                Response.Write("Special Needs: " + C[k].SpecialNeed + "<BR>" + "<BR>");

                            }
                        }
                        else
                        {
                            Response.Write("This Person has not entered information about their children yet!" + "<BR>");
                        }
                    }
                }

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