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
        public int nbFace;
        private int face;
        private Random random = new Random();
        public int Face
        {
            get { return face; }
            set
            {
                if (value == 1 || value == 2 || value == 3 || value == 4 || value == 5 || value == 6)
                {
                    face = value;
                }
            }
        }

        // on met des valeurs par défaut dans le constructeur mais il n'est pas utilisé ici
        public De(int NbFace = 5, int AFace = 6)
        {
            nbFace = NbFace;
            Face = AFace;
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string toString = String.Format("The player rolled the dice and obtained {0} ~", Lancer());
            
            return toString;
            Console.ResetColor();
        }

        public int Lancer()
        {
            int lancer = random.Next(1, this.nbFace++);
            return lancer;
        }
    }
}
