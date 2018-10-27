using Menu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.View
{
    class AddUserView
    {
        
        public static void  Display(List<User> users)
        {            
            while(true)
            {
                Console.Clear();                

                Console.Write("UserName: ");
                string UserName = Console.ReadLine();

                Console.Write("Password: ");
                string Password = Console.ReadLine();
                Console.WriteLine("Role: ");
                string Role = Console.ReadLine();

                Console.WriteLine("Do you want to Save? (Y)es,(N)o");
                var result = Console.ReadKey(true);

                if(result.Key == ConsoleKey.Y)
                {
                    users.Add(new User(UserName,Password,Role));
                    return;
                }
                else if(result.Key == ConsoleKey.N)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter the valid key");
                    Console.ReadKey();
                }

            }

           
        }

    }
}
