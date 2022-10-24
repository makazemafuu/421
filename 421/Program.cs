using _421;
using System;
using System.Runtime.InteropServices;

namespace _421
{
    class Program
    {
        static void Main(string[] args)
        {
            string player;
            int playerDice;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What's your name, stranger ?");
            Console.ResetColor();
            player = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("With how many dice would you like to play with ?");
            Console.ResetColor();
            playerDice = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Alrighty then, {0} ! Please, roll the dice now...", player);
            Console.Write("\n");
            Console.ResetColor();
            Wait(0.5f);

            /*// on peu changer directement ici les valeurs pour passer par exemple d'un de6 à un de20)
            De pureRandom = new De();
            // on appelle la méthode ToString plutôt que lancer ~
            Console.WriteLine(pureRandom.ToString());*/

            DeTruque notRandom = new DeTruque("6");
            Console.WriteLine(notRandom.ToString());

        }

        //pause the game for n-seconds (not using Sleep())
        static void Wait(float second)
        {
            Task delay = Task.Delay(TimeSpan.FromSeconds(second));
            delay.Wait();
        }

    }
}
