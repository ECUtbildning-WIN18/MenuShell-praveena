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
        public ConsoleKeyInfo Display()
        {
            Console.Clear();
            Console.WriteLine("Manage Users Menu");
            Console.WriteLine("(1).Add User");
            Console.WriteLine("(2).Search User");
            return Console.ReadKey();
        }
         
    }
}
