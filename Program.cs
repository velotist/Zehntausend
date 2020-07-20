using System;

namespace Zehntausend
{
    class Program
    {
        static void Main(string[] args)
        {
            Game zehntausend = new Game();
            int numberOfPlayers = zehntausend.GetNumberOfPlayers();

            zehntausend.GivePlayersName(numberOfPlayers);

            foreach (Player player in zehntausend.ListOfPlayers)
            {
                Console.WriteLine(player.Id + "  " + player.Name);
            }

            zehntausend.ListOfPlayers[0].Points = 1000;
            Console.WriteLine(zehntausend.ListOfPlayers[0].Points);

            Console.Write("Save game? y/n ");
            if(Console.ReadKey().Key == ConsoleKey.Y)
            {
                zehntausend.SaveGameToCsv();
            }
        }
    }
}