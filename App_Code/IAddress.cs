using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for IAddress :Interface for creating new Address Class
/// </summary>
/// 
//Written by Tanzila
interface IAddress
{
    int Id { get; set; }
    string Street1 { get; set; }
    string Street2 { get; set; }
    string City { get; set; }
    string State { get; set; }
    string Zip { get; set; }
    int Pid { get; set; }

    double Distance { get; set; }

    string GetFullAddress();
    void AddressToLatLon();
    NewAddress LatLonToAddress();

    void SaveAddressDB(int pid);

}