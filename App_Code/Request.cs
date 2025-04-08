using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// For object instance of BabySitting Request 
/// Author: Tanzila
/// </summary>
public class Request : IRequest
{
    int rid;
    string rdate;
    string stime;
    string etime;
    string comments;
    int pid;
    int cid;

    public Request()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int Cid
    {
        get
        {
            return cid;
        }

        set
        {
            cid = value;
        }
    }

    public string Comments
    {
        get
        {
            return comments;
        }

        set
        {
            comments = value;
        }
    }

    public string EndTime
    {
        get
        {
            return etime;
        }

        set
        {
            etime = value;
        }
    }

    public int Pid
    {
        get
        {
            return pid;
        }

        set
        {
            pid = value;
        }
    }

    public string RDate
    {
        get
        {
            return rdate;
        }

        set
        {
            rdate = value;
        }
    }

    public int Rid
    {
        get
        {
            return rid;
        }

        set
        {
            rid = value;
        }
    }

    public string StartTime
    {
        get
        {
            return stime;
        }

        set
        {
            stime = value;
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
}