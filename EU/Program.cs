using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("EUcsatlakozas.txt");
            List<Tagallam> tagallamok = new List<Tagallam>();

            foreach (string item in adatok)
            {
                Tagallam eutag = new Tagallam(item);
                tagallamok.Add(eutag);
            }

            //3. feladat
            int N = tagallamok.Count;
            Console.WriteLine($"3. feladat: EU tagállamainak a száma: {N}");

            //4. feladat
            int csatlakozok2007ben = 0;
            for (int i = 0; i < N; i++)
            {
                if (tagallamok[i].getCsatlakozasDatuma().Contains("2007"))
                {
                    csatlakozok2007ben++;
                }
            }
            Console.WriteLine($"4. feladat: 2007-ben {csatlakozok2007ben} ország csatlakozott.");

            //5. feladat
            for (int i = 0; i < N; i++)
            {
                if(tagallamok[i].getOrszag() == "Magyarország")
                {
                    Console.WriteLine($"5. feladat: Magyarország csatlakozásának a dátuma {tagallamok[i].getCsatlakozasDatuma()}");
                }
            }

            Console.ReadLine();
        }
    }
}
