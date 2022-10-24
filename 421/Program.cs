using System;

namespace _421
{
    class Program
    {
        static void Main(string[] args)
        {
            string player;

            Console.WriteLine("What's your name, stranger ?");
            player = Console.ReadLine();

            Console.WriteLine("Alrighty then, {0} ! Please, roll the dice now...", player);
            Console.ReadLine();

            De UnDe = new De(5, 1);
            De UnAutreDe = new De(5, 2);
            De UnTroisiemeDe = new De(5, 3);
            De UnQuatriemeDe = new De(5, 4);
            De UnCinquiemeDe = new De(5, 5);
            De UnDernierDe = new De(5, 6);

            De[] CatalogueDe = new De[] { UnDe, UnAutreDe, UnTroisiemeDe, UnQuatriemeDe, UnCinquiemeDe, UnDernierDe };


        }
    }
}