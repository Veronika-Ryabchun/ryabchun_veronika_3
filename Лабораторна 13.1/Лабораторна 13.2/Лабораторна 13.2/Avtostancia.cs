using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_13._2
{
    class Avtostancia
    {
        private Avtobus[] busiki;
        public Avtostancia(Avtobus[] busiki)
        {
            this.busiki = busiki;

        }
        public int Kilkict()
        {
            return busiki.Length;
        }
        public Avtobus find(string nomer)
        {
            for (int i = 0; i < busiki.Length; i++)
            {
                if (nomer == busiki[i].nomer)
                    return busiki[i];
            }
            return null;
        }
        public Avtobus[] find(int ot, int po)
        {
            int a = 1;
            Avtobus[] vybir = new Avtobus[a];
            for (int i = 0; i < busiki.Length; i++)
            {
                if ((ot <= busiki[i].spojivannya) && (busiki[i].spojivannya <= po))
                {
                    vybir[a - 1] = busiki[i];
                    a++;
                    Array.Resize(ref vybir, a);
                }
            }
            return vybir;
        }
        public void Print()
        {
            foreach (Avtobus a in busiki)
            {
                Console.WriteLine(a.ToString());
            }
        }
        public void Sort()
        {
            Array.Sort(busiki);
        }
    }
}

