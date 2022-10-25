using _421;
using System;
using System.Runtime.InteropServices;

namespace _421
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("421 Game");

            Console.WriteLine("Very well. With how many dice would you like to play with ?");
            int nbNormalDice = int.Parse(Console.ReadLine());

            Console.WriteLine("Alright ! Now pssst... come closer... should I add in some loaded dice for you young fellow ? How many ?");
            int nbLoadedDice = int.Parse(Console.ReadLine());

            Console.Write("I knew you were a team player ! *cougs*");
            Console.WriteLine("How many rounds will it be, sir ?");
            int nbRounds = int.Parse(Console.ReadLine());

            Game game = new Game(nbNormalDice, nbLoadedDice, nbRounds);
            game = 



        }

    }
}
