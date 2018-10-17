using Menu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Services
{
    class AuthenticateService : IAuthenticateService
    {
        public User Authenticate(List<User> users, string username, string password)          //Metod: kontroll av anvnamn och password
        {
            return users.FirstOrDefault(x => x.Username == username && x.Password == password); //använder LINQ. kollar om det stämmer
        }
    }
}
