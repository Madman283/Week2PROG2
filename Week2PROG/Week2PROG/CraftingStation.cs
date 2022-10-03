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
        Person Trader = new Person();
        public void Start()
        {
            //concatenation
            //Print("Welcome" + Player.Name + "to the CS!");

            ////composite
            //Console.WriteLine("Welcome {0} to the CS!", Player.Name);

            ////interpolation
            Print($"welcome {Player.Name} to the CS!");

            Trader.Inventory = GetInventoryFromExtrenal("../../data/ReadHere.txt");

            halt();
            StartMenu();
            

        }

        private void StartMenu()
        {
            Print($"Welcome the the Menu {Player.Name}");
            Print("These are your options!");
            string[] options = { "Inventory", "Change your name", "See Instructions", "See Trader"};

            for (int i = 0; i < options.Length; i++)
            {
                Print($"{i+1}. {options[i]}");
            }
             string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    //inventory
                    Print(Player.ListOfInventory());
                    break;
                case "2": Player.NewName();
                    //Change your name
                    break;
                case "3":
                    ShowInstructions();
                    break;
                case "4": Print(Trader.ListOfInventory());
                    halt();
                    break;

                default:
                    break;
            }

            StartMenu();

        }
        
        private void ShowInstructions()
        {


            Print(ReadTextFromExternalFile("../../data/instruction.txt"));
            halt();
        
        }
    }
}