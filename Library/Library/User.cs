using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

    class User
    {
    private int UserID;
    private string UserName;
    private string Email;
    public int userID { get { return UserID; } }
    public string username { get { return UserName; } set { UserName = value; } }
    public string email { get { return Email; } set { Email = value; } }

    public User(int id, string name, string email)
    {
        this.UserID = id;
        this.UserName = name;
        this.Email = email;
    }



    }
