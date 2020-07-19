using System;
using System.Collections.Generic;

namespace Zehntausend
{
    class Game
    {
        public List<Player> ListOfPlayers = new List<Player>();

        public int GetNumberOfPlayers()
        {
            Console.Write("Wieviele Spieler (min 2 max 4)? ");
            int numberOfPlayers;
            int.TryParse(Console.ReadLine(), out numberOfPlayers);

            return numberOfPlayers;
        }
    }
}