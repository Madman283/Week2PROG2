using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Week2PROG.Utility;
using static System.Console;

namespace Week2PROG
{
    public class Person
    {
        private string name = "Anom Player";
        private double currency = 30.78;



        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public void NewName()
        {
            Print("Please enter a new name");
            Name = ReadLine();
            Print($"Your name is now {name}.");
        }

        public List<Item> Inventory = new List<Item>()
        {
            new Item()
            {
                Name = "Sticks",
                Amount = 2,
                Value = 5,

            },

            new Item()
            {
                Name = "Wood Blocks",
                Amount = 3,
                Value = 10,
            },


            //new Item("Map", 3.4), //uses constuctor

            //new Item() //object initialization
            //{
            //    Name = "Statue",
            //    Value = 52.10
            //}
        };

        

        public string ListOfInventory()
        {
            string listed = "";
            foreach(Item i in Inventory)
            {
                listed += i.DescriptionOfItems() + Environment.NewLine;
            }
            return listed;
        }


        public double Currency
        {
            get => default;
            set
            {

            }
        }


    }
}