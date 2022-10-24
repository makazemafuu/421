using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTruque
{
    public class Game
    {
        public readonly int nbManches;
        public readonly int nbDes;
        private static List<int> des = new List<int>() { };
        public Game(int NbManches, int NbDes)
        {
            nbManches = NbManches;
            nbDes = NbDes;
        }

        public override string ToString()
        {
            string toString = String.Format("");
            return toString;
        }
    }

}
