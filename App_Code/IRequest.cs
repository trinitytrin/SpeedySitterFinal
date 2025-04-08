using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Interface for setting a request
/// Author: Tanzila
/// </summary>
interface IRequest
{
    int Rid { get; set; }
    string RDate { get; set; }
    string StartTime { get; set; }
    string EndTime { get; set; }
    string Comments { get; set; }
    int Pid { get; set; }
    int Cid { get; set; }
}