using System;
using System.Collections.Generic;

namespace Лабораторна_13._1
{
    class Krylo
    {
        public string krylo = "довге";
    }
    class Shasi
    {
        public string shasi = "велике";
    }
    class Dvygun
    {
        public string dvygun = "потужний";
    }
    class Litak
    {
        public Litak()
        {
            krylo = new Krylo();
            shasi = new Shasi();
            dvygun = new Dvygun();
        }
        public Krylo krylo;
        public Shasi shasi;
        public Dvygun dvygun;
        public string litaty;
        List<string> marshrut = new List<string>();
        public override string ToString()
        {
            return $"У нашого лiтака крило {krylo.krylo}, шасi {shasi.shasi} та двигун {dvygun.dvygun}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Litak other)
            {
                return krylo == other.krylo && shasi == other.shasi && dvygun == other.dvygun;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return krylo.GetHashCode() + dvygun.GetHashCode() + shasi.GetHashCode() ;
        }
        public string Litaty()
        {
            Console.Write("Чи лiтає лiтак? (1-так) ");
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                return litaty = "Так";
            }
            else
            {
                return litaty = "Hi";
            }
        }
        public List<string> Marshrut()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("Мiсто (Для кiнця введiть 'Все'): ");
                string marsh = Console.ReadLine();
                marshrut.Add(marsh);
                if (marsh == "Все")
                {
                    break;
                }
                i++;
            }
            marshrut.Remove("Все");
            return marshrut;
        }
        public void Print ()
        {

            Console.WriteLine("Маршрут:"); 
            for (int p = 0; p < marshrut.Count; p++)
            {
                Console.WriteLine(marshrut[p]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Litak litak = new Litak();
            Console.WriteLine(litak.ToString());
            if (litak.Litaty() == "Так")
            {
                litak.Marshrut();
                litak.Print();
            }
        }
    }
}
