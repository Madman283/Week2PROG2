using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
namespace Dictionary1
{
    internal class Quiz
    {
        string title = "OOP Terminology Quiz";
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public void Start()
        {
            LoadData();
            Menu();
        }
        //FIRST   
        private void LoadData()
        {
            //Complete this one first

            string[] contents = File.ReadAllLines("../../Data/Info.txt");
            

            for (int i = 0; i < contents.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    dictionary.Add(contents[i].ToLower(), contents[i + 1]);
                }
                
            }

            //save data read in to the contents string array
            //to the Terms dictionary structure
            //using Key-Value pairs for the
            //terms and definitions
        }

        //SECOND    

        private string GetAllData()
        {
            string output = "";
            //add code here 
            //return all keys and values
            //from the Terms dictionary
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            return output;
        }

        //THIRD

        private void Menu()
        {
            Print(title);

            string[] options = { "Quiz", "Show all terms and definitions", "Search for term", "Exit" };
            for (int i = 0; i < options.Length; i++)
            {
                Print($"  {i + 1}) {options[i]}");
            }

            Show("Enter an option: ");
            switch (ReadLine())
            {
                case "1":
                    //  Quiz on the terms and definitions
                    StartQuiz();
                    break;
                case "2":
                    // View all terms and definitions
                    Print(GetAllData());
                    break;
                case "3":
                    //  Search the terms and definitions
                    Print(TermSearch());
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Print($"Please enter a number corresponding to an option in the list (1 to {options.Length}).");
                    break;
            }

            Pause();

            //recursive call to Menu
            Menu();
        }
        //FOURTH

        private void StartQuiz(int quizLength = 10) //default can be set as parameter
        {

            //add code here 
            //show dictionary data as quiz
            for (int i=0; i< quizLength; i++) 
            {


                foreach (var item in dictionary)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                //ran into a stump :(

            }

        }


        private void Print(string output) => WriteLine($"{output}");
        private void Show(string output) => Write($"{output}");
        private void Pause()
        {
            Print("Press any key to continue...");
            ReadKey();
            Clear();
        }
        private string TermSearch()
        {
            Show("Enter a term to search for: ");
            return Find(ReadLine());
        }
        private string Find(string itemName)
        {
            //TODO: make the itemName the same case as what is stored in the dictionary
            if (dictionary.ContainsKey(itemName.ToLower()))
            {
                return dictionary[itemName];
            }
            return $"Sorry, {itemName} was not found.";
        }
        //FIFTH
        //complete the basic and advanced functionality items that aren't included in this framework

    }
}

