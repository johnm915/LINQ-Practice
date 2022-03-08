using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myGames = new List<string>
            { "Grand Theft Auto, Super Mario 3D, Halo, NBA 2K, NFL 2K1"};

            var mygames =
                myGames.OrderBy(name => name.Length).ToList();

            foreach (var  gameName in myGames)
            {
                Console.WriteLine(gameName);
            }
        }
    }
}
