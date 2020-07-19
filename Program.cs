using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zehntausend
{
    class Program
    {
        static void Main(string[] args)
        {
            Game chicago = new Game();
            int numberOfPlayers = chicago.GetNumberOfPlayers();

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.Write("Spielername {0}: ", i);
                Player player = new Player(i, Console.ReadLine());
                chicago.ListOfPlayers.Add(player);
            }

            foreach (Player player in chicago.ListOfPlayers)
            {
                Console.WriteLine(player.Id + "  " + player.Name);
            }
        }
    }
}