using Menu.Domain;
using Menu.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Menu.View
{
    class LoginView
    {
        private readonly List<User> _users;
        public LoginView(List<User> users)
        {
            _users = users;
        }
        public User Display()
        {
            Console.Clear();
            Console.WriteLine("Please Log in\n");

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.WriteLine("\nIs this correct? (Y)es (N)o");
            string keyInfo = Console.ReadLine();
                                   
            if (keyInfo=="Y" && keyInfo=="y")
            {
                var authenticateService = new AuthenticateService();
                var user = authenticateService.Authenticate(_users, username, password);
                if (user != null)
                {
                    Console.WriteLine("Successfully logged in!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine($"Role{user.Role}");
                    return user;
                }
                else
                {
                    Console.WriteLine("Access Denied!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Display();
                }
            }
            else if(keyInfo=="N")
            {
                Console.Clear();
                Console.WriteLine("Enter Valid Credentials");
                Display();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong input please try again!");
                Display();
                
            }

            Console.ReadKey();
            
        }
       

    }
}
