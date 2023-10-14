using System;
using System.Collections.Generic;
namespace LINQ
{

    class Program
    {
        static void Main()
        {
            List<string> videoGames = new List<string>
        {
            "Mario", "Zelda", "Metroid", "Final Fantasy", "Street Fighter", "Tetris", "Minecraft"
        };
            var filteredGames = videoGames.Where(game => game.Length > 5);
            Console.WriteLine($"Games with more than 5 characters: {string.Join(", ", filteredGames)}");

            Console.WriteLine("----------------");

            var gameLengths = videoGames.Select(game => game.Length);
            Console.WriteLine($"Lengths of game names: {string.Join(", ", gameLengths)}");

            Console.WriteLine("----------------");

            var orderedByLength = videoGames.OrderBy(game => game.Length);
            Console.WriteLine($"Ordered by length: {string.Join(", ", orderedByLength)}");

            Console.WriteLine("----------------");

            var orderedByLengthDesc = videoGames.OrderByDescending(game => game.Length);
            Console.WriteLine($"Ordered by length (descending): {string.Join(", ", orderedByLengthDesc)}");

            Console.WriteLine("----------------");

            var totalLength = videoGames.Sum(game => game.Length);
            Console.WriteLine($"Total length of game names: {totalLength}");

            Console.WriteLine("----------------");

            var avgLength = videoGames.Average(game => game.Length);
            Console.WriteLine($"Average length of game names: {avgLength}");

            Console.WriteLine("----------------");

            var gameCount = videoGames.Count();
            Console.WriteLine($"Number of games: {gameCount}");


            Console.WriteLine("----------------");


            var shortestGame = videoGames.Min(game => game.Length);
            Console.WriteLine($"Shortest game name length: {shortestGame}");


            Console.WriteLine("----------------");


            var longestGame = videoGames.Max(game => game.Length);
            Console.WriteLine($"Longest game name length: {longestGame}");

            Console.WriteLine("----------------");

            var firstThreeGames = videoGames.Take(3);
            Console.WriteLine($"First three games: {string.Join(", ", firstThreeGames)}");

            Console.WriteLine("----------------");

            var extendedList = videoGames.Append("Halo");
            Console.WriteLine($"List with Halo appended: {string.Join(", ", extendedList)}");

            Console.WriteLine("----------------");

            var orderedGames = videoGames.OrderBy(game => game.Length).ThenBy(game => game);
            Console.WriteLine($"Ordered by length, then alphabetically: {string.Join(", ", orderedGames)}");
        }
    }

}
    
