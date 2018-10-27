using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.View
{
    class AdminView 
    {
        public ConsoleKeyInfo Display()
        {
            Console.WriteLine("Admin Menu");
            Console.WriteLine("(1).Manage Users");            
            Console.WriteLine("(2).Exit");           

            return Console.ReadKey();
        }
    }
}
