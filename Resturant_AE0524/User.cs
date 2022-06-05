using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_AE0524
{
    public class User
    {
     
        
       public String Username { get; set; }
        public String Password { get; set; }

        public User()
        {

        }

        public User( String username, String password)
        {
            
            Username = username;
            Password = password;

        } 
    }


}
