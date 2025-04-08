using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


//Class for showing personal information of the current session user.
//Author: Tanzila

public partial class ViewPersonProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string session_user = Session["USER_NAME"].ToString();


            Person CurrenntUser = new Person();

            CurrenntUser = PersonInfoGetter.GetPersonInfoByUsername(session_user);


            Response.Write("<H2>Showing Your Personal Information</H2>" + "<BR>");
            Response.Write("Name: " + CurrenntUser.FName + " " + CurrenntUser.LName + "<BR>");
            Response.Write("Sex: " + CurrenntUser.Sex + "<BR> User Type: " + CurrenntUser.Type + "<BR> Visa Status: " + CurrenntUser.VisaStatus + "<BR>");
            Response.Write("Phone: " + CurrenntUser.Phone + "<BR> Email: " + CurrenntUser.Email + "<BR>" + "<BR>");
        }
        catch (Exception ex)
        {
            this.Session["exceptionMessage"] = ex.Message;
            //Response.Redirect("ErrorDisplay.aspx");
            Response.Write(ex.Message + ex.StackTrace);

        }

    }
}