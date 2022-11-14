using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OggleGame
{
    internal class Board
    {
        string[] letters = { "D", "J", "A", "T", "T", "N", "W", "R", "E", "I", "S", "N", "O", "N", "A", "I" };

        public string ShowBoard()
        {
            string Output = "";
            for (int i = 0; i < 4; i++)
            {
                Output += letters[i] + " ";
            }
            Output += Environment.NewLine;
            for (int i = 4; i < 8; i++)
            {
                Output += letters[i] + " ";
            }
            Output += Environment.NewLine;
            for (int i = 8; i < 12; i++)
            {
                Output += letters[i] + " ";
            }
            Output += Environment.NewLine;
            for (int i = 12; i < 16; i++)
            {
                Output += letters[i] + " ";
            }
            return Output;
        }

    }
}
