using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> VideoGame = new List<string>() { "Ni no Kuni", "Pokemon Violet", "Legend of Zelda Wind Waker" };

            var orderedgames = VideoGame.OrderBy(x => x).ToList();

            Console.WriteLine("Ordered List of Video Games by Length");
            foreach (var game in orderedgames)
            {
                Console.WriteLine(game);
            }





        }
    }
}