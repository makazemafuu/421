using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421
{
    public class DeTruque : De
    {
        Random rnd = new Random();
        public DeTruque(int NbFace, int AFace) : base(NbFace, AFace)
        {
            nbFace = NbFace;
            Face = AFace;
        }
        public int Lancer()
        {
            int lancer = rnd.Next(1, 7);
            return lancer;
        }
    }
}
