using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7DemoWPF
{
    internal class Player
    {
        public string Name = "Anom Plyer";
        List<Item> Inventory = new List<Item>();
        public string Information = "backstory for player";

        public Player()
        {
            SetUp();
        }
        private void SetUp()
        {
            Inventory.Add(new Item("map"));
            Inventory.Add(new Item("rock"));
            Inventory.Add(new Item("cupcake"));
        }

        public string ShowInventoryItemNames()
        {
            string output = "";
            foreach (Item i in Inventory)
            {
                output += i.Name + "\n";
            }
            return output;
        }


    }
}
