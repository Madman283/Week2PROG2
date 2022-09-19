using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2PROG
{
    internal class Utility
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public string ConvertTextToLowerCase(string message)
        {
            return message.ToLower();

        }

        public static void halt()
        {
            Print("Press any key to continue.");
            Console.ReadKey();
        }


    }
}
