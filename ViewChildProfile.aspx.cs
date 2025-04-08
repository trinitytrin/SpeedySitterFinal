using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//class to view current users children information
//Author: Tanzila
public partial class ViewChildProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string session_user = Session["USER_NAME"].ToString();
            Person CurrenntUser = new Person();         
            CurrenntUser = PersonInfoGetter.GetPersonInfoByUsername(session_user);

            Child[] C = new Child[0];
            C = ChildInfoGetter.GetChildInfo(C, CurrenntUser.Pid);

            if (C.Length > 0)
            {
                Response.Write("<H2>Showing information about your children" + "</H2><BR>");

                for (int k = 0; k < C.Length; k++)
                {
                    Response.Write("<H3>Child  Name: " + (k + 1) + " : " + C[k].FName + " " + C[k].LName + "</H3><BR>");
                    Response.Write("Sex: " + C[k].Sex + ", Date of Birth: " + C[k].DOB + "<BR>");
                    Response.Write("Special Needs: " + C[k].SpecialNeed + "<BR>" + "<BR>");

                }
            }
            else
            {
                Response.Write("<H3>Seems like you have not registered information about your children here!" + "</H3><BR>");
                Response.Write("<H3>If You have children please go to Child Registration Tab to register them to the system" + "</H3><BR>");
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