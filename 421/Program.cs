using _421;
using System;
using System.Runtime.InteropServices;

namespace _421
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- 421 Game ---\n");

            Console.WriteLine("Hello there, welcome to the best game ever ! *coughs*");
            Console.WriteLine("What's your name, pal ?\n");
            string name = Console.ReadLine();

            Console.Write("\nVery well {0}. With how many dice would you like to play with ? Please choose :  ", name);
            int nbNormalDice = int.Parse(Console.ReadLine());

            Console.Write("\nAlright ! Now pssst... come closer... should I add in some loaded dice for you young fellow ? How many ? Please choose : ");
            int nbLoadedDice = int.Parse(Console.ReadLine());

            Console.Write("\nI knew you were a team player ! *cougs*");
            Console.Write("How many rounds will it be, sir ? Please choose : ");
            int nbRounds = int.Parse(Console.ReadLine());

            Game game = new Game(nbNormalDice, nbLoadedDice, nbRounds);
            game.Run();

            int finalPlayerScore = game.Score();
            Console.WriteLine("\nYour score is of {0}\n", finalPlayerScore);



        }

    }
}
