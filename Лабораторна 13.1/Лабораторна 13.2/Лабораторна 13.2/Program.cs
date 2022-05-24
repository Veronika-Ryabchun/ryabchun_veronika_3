using System;
using System.Collections;

namespace Лабораторна_13._2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Malenkiy malenkiy = new Malenkiy(24, "01", 100);
            Seredniy seredniy = new Seredniy(30, 6, "02", 200);
            Velykiy velykiy = new Velykiy(40, 8, 2, "03", 350);
            Avtobus[] avtobusy = new Avtobus[] { velykiy, malenkiy, seredniy };
            Avtostancia avtostancia = new Avtostancia(avtobusy);
            Console.WriteLine("Зараз автобусiв "+avtostancia.Kilkict());
            Console.Write("Введiть номер: ");
            string poshuk_nomer = Console.ReadLine();
            Avtobus znaydeniy = avtostancia.find(poshuk_nomer);
            if (znaydeniy == null)
                Console.WriteLine($"Автобус з номером {poshuk_nomer} не знайдено");
            else
                Console.WriteLine(znaydeniy.ToString());
            Console.Write("Дiапазон споживання палива вiд: ");
            int diapazon_poch = int.Parse(Console.ReadLine());
            Console.Write("До: ");
            int diapazon_kin = int.Parse(Console.ReadLine());
            Avtobus[] znaydeni_avtobusi = avtostancia.find(diapazon_poch, diapazon_kin);
            if (znaydeni_avtobusi.Length==1)
                Console.WriteLine("Таких автобусiв немає");
            else
            {
                Console.WriteLine("Знайдено автобуси з такими номерами:");
                for (int i = 0; i<znaydeni_avtobusi.Length-1; i++)
                {
                    Console.WriteLine(znaydeni_avtobusi[i].nomer);
                }
            }
            avtostancia.Sort();
            avtostancia.Print();
        }
    }
}
