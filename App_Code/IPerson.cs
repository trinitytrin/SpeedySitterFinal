using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;
using System.Threading.Tasks;
//Written By Anitha and Ashvija
/// <summary>
/// Summary description for IPerson : Interface to create class of Person
/// </summary>
interface IPerson
{ 
    int Pid { get; set; }
    string FName { get; set; }
    string LName { get; set; }
    string Sex { get; set; }
    string Email { get; set; }
    string Phone { get; set; }
    string Type { get; set; }
    string VisaStatus { get; set; }
    
    

    void Login();
     void Register();
    void SetAddress(NewAddress nad);

    void FindNearby();

    string GetAddress();

}