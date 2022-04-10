using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>();
            videoGames.Add("Tetris");
            videoGames.Add("Mario Cart");
            videoGames.Add("Sonic the Hedgehog");
            var videoGamesOrderedByLength = videoGames.OrderBy(game => game.Length);

            foreach (var game in videoGamesOrderedByLength)
            {
                Console.WriteLine(game);
            }
        }
    }
}
