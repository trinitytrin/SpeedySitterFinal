using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;


using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.WebControls.Expressions;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Windows;
/// <summary>
/// Summary description for DBOperation: Class to handle Database Operations
/// 
//Written by Tanzila
public class DBOperation : IDBOperation
{
    string connectionString = @"Data Source = localhost; Database=speedy_sitter; User ID = Trina; Password=123";

    public NewAddress AddressToLatLong
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public void DBConnect(string cs)
    {
        try
        {
            string connectionString = @"Data Source=localhost; Database=speedy_sitter; User ID=Trina; Password=123";
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                cn.Open();
                //Response.Write("MySQL connection successful!");
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM address"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = cn;
                        sda.SelectCommand = cmd;

                        DataTable dt = new DataTable();

                        sda.Fill(dt);
                        //GridView.DataSource = dt;
                        //GridView.DataBind(dt);


                        // GridView.DisabledCssClass

                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.Write("Exception caught in Service page connection to database: " + ex);

        }
    }
}