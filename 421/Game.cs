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
            this.nbDes = 6;

            for (int i = 0; i < nbDes - 2; i++)
            {

                des.Add(new De("6"));
            }

            for (int i = nbDes - 2; i < nbDes; i++)
            {
                des.Add(new DeTruque("6"));
            }

        }

        // constructeur avec création d'une nouvelle liste de dés (pour avoir plusieurs dé6)
        public Game(int NbNormalDice, int NbLoadedDice, int NbRounds)
        {
            this.nbManches = NbRounds;
            this.nbDes = NbNormalDice + NbLoadedDice;
            des = new List<De>();

            for (int i = 0; i < NbNormalDice; i++)
            {
                des.Add(new De("6"));
            }

            for (int i = 0; i < NbLoadedDice; i++)
            {
                des.Add(new DeTruque("6"));
            }

        }

        // affichage pour les dés
        public override string ToString()
        {
            string toString = String.Format("");
            for (int i = 0; i < des.Count; i++)
            {
                toString += String.Format("+---+ ");
            }
            toString += String.Format("\n");
            for (int i = 0; i < des.Count; i++)
            {
                toString += String.Format("| {0} | ", des[i].Face);
            }
            toString += String.Format("\n");
            for (int i = 0; i < des.Count; i++)
            {
                toString += String.Format("+---+ ");
            }
            return toString;
        }

        // méthode pour relancer les dés, la boucle for sert à dire que seul les dés qui ne sont pas à 6 peuvent être relancé (puisqu'on fait le plus haut score et que 6 est le maximum)
        // on ajouter à la liste avec un list.Add
        public int Relancer(int i)
        {
            des[i - 1].Lancer();
            return 0;
        }

        public int Score()
        {
            int finalScore = 0;
            foreach (De de in des)
            {
                finalScore += de.Face;
            }
            return finalScore;
        }

        public int Run()
        {
            int nbManchesLeft = nbManches;

            while (nbManches > 0)
            {
                bool problem = false;
                Console.WriteLine(ToString());

                string relanceDes;
                Console.WriteLine("How many dice would you like to roll back (please write as the following example : \"x,y\" ? or write \"Q\" (or \"q\") to quit ~)\n");
                relanceDes = Console.ReadLine();

                if (relanceDes == "Q" || relanceDes == "q")
                {
                    break;
                }
                else
                {
                    string[] listRelanceDes = relanceDes.Split(',');
                    foreach (string str in listRelanceDes)
                    {
                        int leDe = int.Parse(str);
                        // Console.WriteLine(leDe);

                        if (leDe < 1 || leDe > nbDes)
                        {
                            Console.WriteLine("Nope, pick different ones.");
                            problem = true;
                            break;
                        }
                        else
                        {
                            Relancer(leDe);
                        }
                    }

                    if (problem)
                    {
                        continue;
                    }
                }
                nbManchesLeft--;
            }
            return 0;
        }

        // pause the game for n-seconds (not using Sleep())
        static void Wait(float second)
        {
            Task delay = Task.Delay(TimeSpan.FromSeconds(second));
            delay.Wait();
        }
    }

}
