using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Class to calculate distance between two addresses
/// Author: Tanzila
/// </summary>
public class DistanceCalculator
{
    public GetDBAddress CalculatesDistance
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

    public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
    {
        try
        {
            double distance = 0.0;
            //Console.WriteLine("This program calculates distance between two geo points, \nGiven their latitude longitude");


            double R = 6371; //radius of earth in km



            double dlat1 = lat1 * (Math.PI / 180);
            double dlat2 = lat2 * (Math.PI / 180);

            double dlat = (lat1 - lat2) * (Math.PI / 180);
            double dlon = (lon1 - lon2) * (Math.PI / 180);

            double a = (Math.Pow((Math.Sin(dlat / 2)), 2))
                        + ((Math.Cos(dlat1)) * (Math.Cos(dlat2)) * (Math.Pow((Math.Sin(dlon / 2)), 2)));

            double c = 2 * (Math.Atan2((Math.Sqrt(a)), (Math.Sqrt(1 - a))));

            distance = R * c;

            //Console.WriteLine("Distance between {0},{1} and {2},{3} is \n= {4} Km", lat1, lon1, lat2, lon2, distance);

            return distance;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Press any key to terminate..");
            Console.ReadKey();
            Environment.Exit(0);
            return 0.0;
        }
    }
    public DistanceCalculator()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}