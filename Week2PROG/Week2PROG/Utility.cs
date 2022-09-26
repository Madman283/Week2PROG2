using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        public static string ReadTextFromExternalFile(string fileName)
        {
            if (File.Exists(fileName))
            return File.ReadAllText(fileName);

            return "Info unavalible right now";
        }
        public static List<Item> GetInventoryFromExtrenal(string fileName)
        {
            List<Item> inventory = new List<Item>();
            string[] itemNames = File.ReadAllLines(fileName);
            foreach (string name in itemNames)
            {
                inventory.Add(new Item() { Name = name });
            }

            return inventory;
        }

    }
}
