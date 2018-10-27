using Menu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Menu.View
{
    class DeleteUserView
    {
        public static void DeleteUser(List<User> users)
        {
            Console.Clear();
            foreach (User user in users)
            {
                Console.WriteLine(user.Username);
            }
            Console.WriteLine(">");
            var choice = Console.ReadLine();
            foreach(User user in users)
            {
                if(choice == user.Username.ToLower())
                {
                    var itemtoRemove = users.SingleOrDefault(x => x.Username == choice);
                    users.Remove(itemtoRemove);
                    Console.WriteLine($"User {choice} deleted Successfully");
                    Thread.Sleep(2000);
                }
                else if(choice != user.Username.ToLower())
                {
                    Console.WriteLine($"User {choice} doesnot exist");
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
