using Menu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Services
{
    interface IAuthenticateService
    {
        User Authenticate(List<User> users, string username, string password);
    }
}
