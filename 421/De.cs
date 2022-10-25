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
        public string nbFace;
        private int face;
        private Random random = new Random();
        
        // pour faire un get; set;
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

        // dans un constructeur on n'est pas obligé de tout mettre
        // on peu appeler une méthode dans un constructeur également
        public De(string NbFace)
        {
            nbFace = NbFace;
            Lancer();
        }
        public override string ToString()
        {
            string toString = String.Format("The player rolled the dice and obtained {0} ~", Face);
            return toString;

        }

        // méthode pour lancer de manière aléatoire
        public virtual int Lancer()
        {
            Face = random.Next(1, int.Parse(nbFace)+1);
            return Face;
        }
    }
}
