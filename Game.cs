using System;
using System.Collections.Generic;
using System.IO;

namespace Zehntausend
{
    class Game
    {
        public List<Player> ListOfPlayers = new List<Player>();

        public int GetNumberOfPlayers()
        {
            int numberOfPlayers;

            do
            {
                Console.Write("Wieviele Spieler (min 2 max 4)? ");
                int.TryParse(Console.ReadLine(), out numberOfPlayers);
                Console.WriteLine();
            } while (numberOfPlayers < 2 || numberOfPlayers > 4);

            return numberOfPlayers;
        }

        public void GivePlayersName(int numberOfPlayers)
        {
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.Write("Spielername {0}: ", i);
                Player player = new Player(i, Console.ReadLine());
                ListOfPlayers.Add(player);
            }
        }

        public void SaveGameToCsv()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\velot\zehntausend.csv"))
            {
                foreach (Player player in ListOfPlayers)
                {
                    writer.WriteLine($"{player.Id};{player.Name};{player.Points}");
                }
            }
        }
    }
}