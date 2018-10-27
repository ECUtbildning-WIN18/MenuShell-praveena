using Menu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.View
{
    class ManageUserView
    {
        public static void Display(List<User> users)
        {
            Console.Clear();
            Console.WriteLine("Manage Users Menu");
            Console.WriteLine("(1).Add User");
            Console.WriteLine("(2).Delete User");
            var choice= Console.ReadKey();
            if (choice.Key == ConsoleKey.D1)
            {
                AddUserView.Display(users);
            }
            else if (choice.Key == ConsoleKey.D2)
            {
                DeleteUserView.DeleteUser(users);
            }
        }
    }
}
