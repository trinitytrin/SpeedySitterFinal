using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Address
/// </summary>
public class Address
{
    static double lat;
    static double lon;

    public static double Lat
    {
        get { return lat; }
        set { lat = value; }
    }
    public static double Lon
    {
        get { return lon; }
        set { lon = value; }
    } 
    public Address()
    {
        //
        // TODO: Add constructor logic here
        lat = 0.0;
        lon = 0.0;
    }
}