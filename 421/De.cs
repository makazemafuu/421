using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _421
{
    public class De
    {
        public int nbDes = 5;
        private int face = 6;
        Random random = new Random();
        public int Face
        {
            get { return face; }
            set
            {
                if (value == 1 || value == 2 || value == 3 || value == 4 || value == 5 || value == 6)
                {
                    face = value;
                }
                else
                {
                    face = 0;
                    Console.WriteLine("Please, reroll the dice !");
                }
            }
        }

        public De(int NbDes, int AFace)
        {
            nbDes = NbDes;
            Face = AFace;
        }

        public override string ToString()
        {
            string toString = String.Format("The player rolled the dice and obtained {0}", this.face);
            return toString;
        }

        public int Lancer()
        {
            int lancer = random.Next(1, 7);
            return lancer;
        }
    }
}
