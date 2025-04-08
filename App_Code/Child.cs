using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Class for creating child instance
/// Author: Tanzila
/// </summary>
public class Child: IChild
{
    int cid;
    string fname;
    string lname;
    string sex;
    string dob;
    string specialNeed;
    int pid;
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

    public string DOB
    {
        get
        {
            return dob;
        }

        set
        {
            dob = value;
        }
    }

    public string FName
    {
        get
        {
            return fname;
        }

        set
        {
            fname = value;
        }
    }

    public string LName
    {
        get
        {
            return lname;
        }

        set
        {
            lname = value;
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

    public string Sex
    {
        get
        {
            return sex;
        }

        set
        {
            sex = value;
        }
    }

    public string SpecialNeed
    {
        get
        {
            return specialNeed;
        }

        set
        {
            specialNeed = value;
        }
    }

    public ChildInfoGetter ChildInfoGetter
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public Child()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}