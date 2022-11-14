using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Dictionary1
{
    class Program
    {
        static void Main()
        {
            Quiz quiz = new Quiz();
            quiz.Start();

            //Console.Title = "Dictionary Example";
            //Atomic atomic = new Atomic();
            //Console.ReadKey();
        }
    }

    class Atomic
    {
        Dictionary<string, int> atomicweights = new Dictionary<string, int>();
        public Atomic()
        {
            atomicweights.Add("Happy", 1); // here we are using the Add method to add key/value pairs
            atomicweights.Add("Sad", 2); // you can add the values when you create the Dictionary, too
            atomicweights.Add("Crying", 3); // see next section for an example
            atomicweights.Add("Strong", 4);

            //print all key value pairs
            foreach (var item in atomicweights)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("Press a number 1-4 to get a definiton for one of the current words.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("feeling or showing pleasure or contentment.");
                    break;
                case "2":
                    Console.WriteLine("feeling or showing sorrow; unhappy.");
                    break;
                case "3":
                    Console.WriteLine("shedding tears.");
                    break;
                case "4":
                    Console.WriteLine("having the power to move heavy weights or perform other physically demanding tasks.");
                    break;

                default:
                    break;
            }

            ////just print keys
            //foreach (var item in atomicweights.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            ////just print values
            //foreach (var item in atomicweights.Values)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
