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
        Random rnd = new Random();
        public DeTruque(int NbFace = 0, int AFace = 0) : base(NbFace, AFace)
        {
            nbFace = NbFace;
            Face = AFace;
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string toString = String.Format("The player rolled the dice and obtained {0} ~", Throw());

            return toString;
            Console.ResetColor();
        }
        public int Throw()
        {
            if (rnd.NextDouble() < 0.5)
            {
                return 6;
            }
            else if (rnd.NextDouble() < 0.16)
            {
                return 5;
            }
            else if (rnd.NextDouble() < 0.083)
            {
                return 4;
            }
            else if (rnd.NextDouble() < 0.083)
            {
                return 3;
            }
            else if (rnd.NextDouble() < 0.083)
            {
                return 2;
            }
            else if (rnd.NextDouble() < 0.083)
            {
                return 1;
            }

            return rnd.Next(1, 6);
        }
    }
}
