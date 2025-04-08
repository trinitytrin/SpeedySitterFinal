using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

//Written by Anitha and Ashvija
/// <summary>
/// Summary description for Person
/// </summary>
public class Person : IPerson
{
    int pid;
    string fname;
    string lname;
    string sex;
    string phone;
    string email;
    string type;
    string visa;
    string username;
    string password;
    
    public Person()
    {
        //
        // TODO: Add constructor logic here
        //
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

    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            email = value;
        }
    }

    public string Phone
    {
        get
        {
            return phone;
        }

        set
        {
            phone = value;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }

        set
        {
            type = value;
        }
    }

    public string VisaStatus
    {
        get
        {
            return visa;
        }

        set
        {
            visa = value;
        }
    }

    public string UserName
    {
        get
        {
            return username;
        }
        set
        {
            username = value;
        }

    }
    
    public string Password
    {
        get
        {
            return password;
        }
        set
        {
            password = value;
        }
    }

    public PersonInfoGetter GetsPersonInfo
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public PersonInfoGetter PersonInfoGetter
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public void FindNearby()
    {
        throw new NotImplementedException();
    }

    public string GetAddress()
    {
        throw new NotImplementedException();
    }

    public void Login()
    {
        throw new NotImplementedException();
    }

    public void Register()
    {
        throw new NotImplementedException();
    }

    public void SetAddress(NewAddress nad)
    {
        throw new NotImplementedException();
    }

    void IPerson.Login()
    {
        throw new NotImplementedException();
    }

    void IPerson.Register()
    {
        throw new NotImplementedException();
    }

    void IPerson.SetAddress(NewAddress nad)
    {
        throw new NotImplementedException();
    }

    void IPerson.FindNearby()
    {
        throw new NotImplementedException();
    }

    string IPerson.GetAddress()
    {
        throw new NotImplementedException();
    }
}