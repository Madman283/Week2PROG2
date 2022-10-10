using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Demo_5
{
    internal class CountUI
    {
        Counter counter;
        public CountUI() => SetUp();

        private void SetUp()
        {
            Clear();
            Title = "Event example with a counter and threshold";
            WriteLine("A random number has been chosen as a threshold.\nNumbers will increment automatically until this threshold has been met.");
            counter = new Counter(GetRandomNumber());
            Run();
        }
        private int GetRandomNumber()
        {
            return new Random().Next(10);
        }

        private void Run()
        {
            WriteLine(IncrementCounter());
            counter.ThresholdReached += c_ThresholdReached;
            Run();
        }
        private int IncrementCounter()
        {
            counter.Add(1);
            return counter.Total;
        }

        private void c_ThresholdReached(object sender, EventArgs e)
        {
            WriteLine($"The threshold {counter.Threshold} was reached. Press any key to run this again, or x to exit.");
            if (Console.ReadKey().Key == ConsoleKey.X)
                Environment.Exit(0);
            //else
            SetUp();
        }
    }
}
