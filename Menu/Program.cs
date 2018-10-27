using Menu.Domain;
using Menu.Services;
using Menu.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();
            {
                users.Add(new User(userName: "John", password: "hello", role: "administrator"));
                users.Add(new User(userName: "Jane", password: "hi", role: "Recep"));
                users.Add(new User(userName: "Jim", password: "secret", role: "administrator"));                
            }
            var logInView = new LoginView(users);
            while (true)
            {
                var loggedInUser = logInView.Display();
                if (loggedInUser.Role == "administrator")
                {
                    var adminview = new AdminView();
                    var selection = adminview.Display();

                    if (selection.Key == ConsoleKey.D1)
                    {
                        var manageUserView =new ManageUserView();
                        var choice=manageUserView.Display();
                        if(choice.Key==ConsoleKey.D1)
                        {
                            AddUserView.Display(users);
                        }
                        else if(choice.Key==ConsoleKey.D2)
                        {                            
                            SearchUserView.Display(users);                            
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Selection");
                            manageUserView.Display();
                        }
                    }
                    else if (selection.Key == ConsoleKey.D2)
                    {
                        Environment.Exit(0);
                    }

                }
                else if (loggedInUser.Role == "Recep")
                {
                    var recepView = new ReceptionistMainMenu();
                    var choice = recepView.Display();
                    if (choice.Key == ConsoleKey.D1)
                    {
                        ListUserView.ListUsers(users);
                    }
                    else if (choice.Key == ConsoleKey.D2)
                    {
                        Environment.Exit(0);
                    }
                }

            }

        }
    }
}
       