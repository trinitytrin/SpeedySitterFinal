using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//class to show current session users current address information
//Author: Tanzila

public partial class ViewAddressProfile : System.Web.UI.Page
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
            if (CurrentUserAddress.Id >= 1)
            {
                Response.Write("<H2>Showing your Current Address Information</H2> <BR>");
                Response.Write("Addressline1: " + CurrentUserAddress.Street1 + "<BR> Addressline2: " + CurrentUserAddress.Street2 + "<BR> City:" + CurrentUserAddress.City + "<BR> State: " + CurrentUserAddress.State + "<BR> Zip: " + CurrentUserAddress.Zip + "<BR>");
                Response.Write("Geocode Latitude: " + CurrentUserAddress.Lat + "<BR> Geocode Longitude: " + CurrentUserAddress.Lon + "<BR>");
                
            }
            else
            {
                Response.Write("<H2>Seems like you have not set your address yet in the system. Please go to Service Tab to Geocode and Set your Address</H2> <BR>");
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