using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Week2PROG.Utility;

namespace Week2PROG
{
    public class CraftingStation
    {
        Person Player = new Person();
        public void Start()
        {
            //concatenation
            //Print("Welcome" + Player.Name + "to the CS!");

            ////composite
            //Console.WriteLine("Welcome {0} to the CS!", Player.Name);

            ////interpolation
            Print($"welcome {Player.Name} to the CS!");


            halt();
            StartMenu();

        }

        private void StartMenu()
        {
            Print($"Welcome the the Menu {Player.Name}");
            Print("These are your options!");
            string[] options = { "Inventory", "Change your name" };

        }
    }
}