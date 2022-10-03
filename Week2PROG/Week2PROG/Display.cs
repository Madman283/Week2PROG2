using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Week2PROG
{
    internal class Display
    {
        public delegate void PrintToPlatform(string message);
        public static PrintToPlatform Print = ConsolePrint;


        public static void ConsolePrint(string message)
        {
            WriteLine(message);
        }

        public static void WPFPrint(string message)
        {
            WriteLine(message);
        }



    }
}
