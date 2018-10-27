using Menu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.View
{
    class DeleteUserView
    {
        //    private readonly List<User> _users;
        //    public DeleteUserView(List<User> users)
        //    {
        //        _users = users;
        //    }
        public static void Display(List<User> users)
        {
            Console.WriteLine();
           /* foreach (User user in users)
            {
                Console.Clear();
                Console.WriteLine(user.Username);
                Console.WriteLine("(D)elete");
                var choice = Console.ReadKey(true);
                if (choice.Key == ConsoleKey.D)
                {
                    Console.WriteLine($"Delete user ? (Y)es,(N)o ");
                    var deluser = Console.ReadKey(true);
                    if (deluser.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine($"User {userSearch} deleted Successfully");
                    }
                    else if (deluser.Key == ConsoleKey.N)
                    {
                        Console.WriteLine(user.Username);
                        Console.WriteLine("(D)elete");
                    }
                }


            }*/
        }
    }
}
