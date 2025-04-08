using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Interface for Child Class
//Author: Tanzila
interface IChild
{
    int Cid { get; set; }
    string FName { get; set; }
    string LName { get; set; }
    string Sex { get; set; }
    string DOB { get; set; }
    string SpecialNeed { get; set; }
    int Pid { get; set; }
}