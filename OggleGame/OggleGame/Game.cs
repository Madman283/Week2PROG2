using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OggleGame
{

    internal class Game
    {
        Board board = new Board();
        public void PlayGame()
        {
            Console.WriteLine(board.ShowBoard());

            Console.ReadKey();
        }

    }
}
