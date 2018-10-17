using Menu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Menu.View
{
    class ListUserView
    {
        public static void ListUsers(List<User>users)
        {
            Console.Clear();
            foreach(User user in users)
            {
                Console.WriteLine(user.Username);
            }
            Console.ReadKey();
        }
    }
}
