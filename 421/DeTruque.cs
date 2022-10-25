using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _421
{
    public class DeTruque : De
    {
        // DeTruque hérite de De

        Random rnd = new Random();
        public DeTruque(string NbFace) : base(NbFace)
        {
            nbFace = NbFace;
        }

        public override string ToString()
        {
            string toString = String.Format("The player rolled the dice and obtained {0} ~", Lancer());
            return toString;
        }

        // méthode pour le dé truqué, on prend une base de 12 pour calculer la probabilité ici puisqu'il est demandé dans les règles d'avoir une chance sur 2, 6 puis 12
        // ici on retourne le résultat avec le setter Face
        public override int Lancer()
        {
            int result = 0;
            int rndNum = rnd.Next(1, 13);

            if (rndNum < 6)
            {
                result = 6;
            }
            else if (rndNum == 6 || rndNum == 7 || rndNum == 8)
            {
                result = 5;
            }
            else if (rndNum == 9)
            {
                result = 4;
            }
            else if (rndNum == 10)
            {
                result = 3;
            }
            else if (rndNum == 11)
            {
                result = 2;
            }
            else if (rndNum == 12)
            {
                result = 1;
            }

            // debug
            // Console.WriteLine(rndNum);
            Face = result;
            return Face;
        }
    }
}
