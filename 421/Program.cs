using _421;
using System;
using System.Runtime.InteropServices;

namespace _421
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("421 Game\n");

            Console.WriteLine("Hello there, welcome to the best game ever ! *coughs*\n");
            Console.WriteLine("What's your name, pal ?\n");
            string name = Console.ReadLine();

            Console.WriteLine("Very well {0}. With how many dice would you like to play with ?\n", name);
            int nbNormalDice = int.Parse(Console.ReadLine());

            Console.WriteLine("Alright ! Now pssst... come closer... should I add in some loaded dice for you young fellow ? How many ?\n");
            int nbLoadedDice = int.Parse(Console.ReadLine());

            Console.Write("I knew you were a team player ! *cougs*\n");
            Console.WriteLine("How many rounds will it be, sir ?\n");
            int nbRounds = int.Parse(Console.ReadLine());

            Game game = new Game(nbNormalDice, nbLoadedDice, nbRounds);
            game.Run();

            int finalPlayerScore = game.Score();
            Console.WriteLine("Your score is of {0}\n", finalPlayerScore);



        }

    }
}
