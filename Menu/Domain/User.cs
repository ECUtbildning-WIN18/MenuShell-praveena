using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Domain
{
    class User
    {
        //public string FirstName { get; }
        //public string LastName { get; }
        public string Username { get; }
        public string Password { get; }
        public string Role { get; }
       
        public User(/*string firstName, string lastName,*/string userName, string password, string role)
        {
            //FirstName = firstName;
            //LastName = lastName;
            Username = userName;
            Password = password;
            Role = role;
        }
    }
}
