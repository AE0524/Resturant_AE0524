using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_AE0524
{
    internal class User
    {
        public int UserId { get; set; }
        public String UserFullname { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public User()
        {

        }

        public User(int userId ,String userFullname , String username ,String password)
        {
            UserId = userId;    
            UserFullname = userFullname;
            Username = username;
            Password = password;

        }
    }
}
