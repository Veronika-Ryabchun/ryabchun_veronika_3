using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_13._2
{
    abstract class Avtobus : IComparable<Avtobus>
    {
        public abstract int miscya { get; }
        public string nomer { get; private set; }
        public int spojivannya { get; private set; }
        public Avtobus(string nomer, int spojivannya)
        {
            this.nomer = nomer;
            this.spojivannya = spojivannya;
        }
        public override string ToString()
        {
            return $"Автобус з номером {nomer} має {miscya} мiсць";
        }
        public int CompareTo(Avtobus bus)
        {
            return miscya.CompareTo(bus.miscya);
        }
    }
}
