using Menu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Menu.View
{
    class SearchUserView
    {
        public static void Display(List<User> users)
        {
            Console.Clear();
            Console.Write("Search by Username:");
            var userSearch = Console.ReadLine();

            //var foundSearch = users.Where(x => x.Username.ToLower().Contains(userSearch));            
            //return foundSearch; 

            foreach (User user in users)
            { 
                if (userSearch == user.Username.ToLower())
                {
                    Console.WriteLine(user.Username);
                    Console.WriteLine("(D)elete");
                    var choice = Console.ReadKey(true);
                    if (choice.Key == ConsoleKey.D)
                    {
                        Console.WriteLine($"Delete user {userSearch} ? (Y)es,(N)o ");
                        var deluser = Console.ReadKey(true);
                        if (deluser.Key == ConsoleKey.Y)
                        {
                            var itemtoRemove = users.SingleOrDefault(x => x.Username == userSearch);
                            users.Remove(itemtoRemove);
                            Console.WriteLine($"User {userSearch} deleted Successfully");
                            Thread.Sleep(2000);
                        }
                        else if (deluser.Key == ConsoleKey.N)
                        {
                            Console.WriteLine(user.Username);
                            Console.WriteLine("(D)elete");
                            Thread.Sleep(2000);
                            var esckey = Console.ReadKey();
                            if (esckey.Key == ConsoleKey.Escape)
                            {
                                var manageUserView = new ManageUserView();
                                manageUserView.Display();
                            }
                        }
                    }
                }
                else if (userSearch != user.Username.ToLower())
                {
                    Console.WriteLine($"No user found matching the search term {userSearch}");
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
