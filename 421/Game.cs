using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.nbManches = 5;
            this.nbDes = 5;

            for (int i = 0; i < nbDes; i++)
            {
                des[i] = new De("6");
            }
        }

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

        public int Relance()
        {
            List<int> list = new List<int>();
            string text = String.Format("What are the dice you wish to reroll ?");
            for (int i = 0; i < nbDes; i++)
            {
                if (des[i].Face != 6)
                {
                    list.Add(i + 1);
                    text += String.Format(i + 1 + ",");
                }
            }
            Console.WriteLine(text);
            int retour = 0;

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
    }

}
