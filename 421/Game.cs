using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace _421
{
    public class Game
    {
        public readonly int nbManches;
        public readonly int nbDes;
        Random rndNbDes = new Random();
        private static List<De> des = new List<De>();
        public Game()
        {
            // dés standards et nombre de manches

            this.nbManches = 5;
            this.nbDes = 5;

            for (int i = 0; i < nbDes; i++)
            {
                des[i] = new De("6");
            }
        }

        // constructeur avec création d'une nouvelle liste de dés (pour avoir plusieurs dé6)
        public Game(int NbManches, int NbDes)
        {
            this.nbManches = NbManches;
            this.nbDes = NbDes;
            des = new List<De>();

            for (int i = 0; i < nbDes; i++)
            {
                des[i] = new De("6");
            }

        }

        // affichage pour les dés
        public override string ToString()
        {
            string toString = String.Format("");
            for (int i = 0; i < nbDes; i++)
            {
                toString += String.Format("+---+ ");
            }
            toString += String.Format("\n");
            for (int i = 0; i < nbDes; i++)
            {
                toString += String.Format("| {0} | ", des[i].Face);
            }
            toString += String.Format("\n");
            for (int i = 0; i < nbDes; i++)
            {
                toString += String.Format("+---+ ");
            }
            return toString;
        }

        // méthode pour relancer les dés, la boucle for sert à dire que seul les dés qui ne sont pas à 6 peuvent être relancé (puisqu'on fait le plus haut score et que 6 est le maximum)
        // on ajouter à la liste avec un list.Add
        public int Relance()
        {
            List<int> list = new List<int>();
            string text = String.Format("What are the dice that you wish to reroll ?");
            for (int i = 0; i < nbDes; i++)
            {
                if (des[i].Face != 6)
                {
                    list.Add(i + 1);
                    text += String.Format(i + 1 + ",");
                }
            }

            // on fait apparaître notre string text après chaque lancer (pour relancer)
            Console.WriteLine(text);
            int retour = 0; // on créer un retour pour que seul des choix valables soient proposés, et si le joueur ne choisi pas un bon nombre, ça lui demande encore

            while (retour < 1 || retour > nbDes)
            {
                bool playerChoice = int.TryParse(Console.ReadLine(), out retour);
                if (!playerChoice || retour < 1 || retour > nbDes)
                {
                    string textChoice = String.Format("Please give me a number between these : ");
                    for (int i = 0; i < list.Count; i++)
                    {
                        textChoice += String.Format(list[i].ToString() + ",");
                    }

                    Console.Write(textChoice);
                }
            }
            des[retour - 1].Lancer();
            return des[retour - 1].Face;
        }

        /*public int Score()
        {
            List<int> list = new List<int>();
            int score = 0;

            for (int i = 0; i < des[i].Face; i++)
            {
                score += des[i].Face;
            }
            return score;
        }*/

        /*public int Run()
        {
            string player;
            int nbDice;

            Console.WriteLine("What's your name, stranger ?");
            player = Console.ReadLine();

            Console.WriteLine("With how many dice would you like to play with ?");
            nbDice = int.Parse(Console.ReadLine());

            Console.WriteLine(nbDes);

            Console.WriteLine("Alrighty then, {0} ! Please, roll the dice now...", player);
            Console.Write("\n");
            Wait(0.5f);

            return Run();
        }*/

        // pause the game for n-seconds (not using Sleep())
        static void Wait(float second)
        {
            Task delay = Task.Delay(TimeSpan.FromSeconds(second));
            delay.Wait();
        }
    }

}
