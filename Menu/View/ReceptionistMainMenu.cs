using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.View
{
    class ReceptionistMainMenu
    {
        public ConsoleKeyInfo Display()
        {
            
            Console.WriteLine("(1).Users List");
            Console.WriteLine("(2).Exit");
             
            return Console.ReadKey();
        }
    }
}
