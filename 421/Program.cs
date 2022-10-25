using _421;
using System;
using System.Runtime.InteropServices;

namespace _421
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();

            
            /*// on peu changer directement ici les valeurs pour passer par exemple d'un de6 à un de20)
            De pureRandom = new De();
            // on appelle la méthode ToString plutôt que lancer ~
            Console.WriteLine(pureRandom.ToString());*/

            DeTruque notRandom = new DeTruque("6");
            Console.WriteLine(notRandom.ToString());

        }

    }
}
