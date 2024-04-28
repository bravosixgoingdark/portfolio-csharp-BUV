using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


    class Admin : User
    {
    float wage;
    public Admin(int id, string name, string email, float wage):base(id,name,email) 
    { 
    this.wage = wage;
    }
    
    }
