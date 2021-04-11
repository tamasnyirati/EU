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
                if (tagallamok[i].getCsatlakozasDatuma().Year == 2007)
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

            //6. feladat
            bool majusiCsatlakozás = false;
            var majus = new DateTime(2004, 5, 1);
            
            for (int i = 0; i < N; i++)
            {
                if (tagallamok[i].getCsatlakozasDatuma().Equals(majus))
                {
                    majusiCsatlakozás = true;
                }
            }
                Console.Write("6. feladat: Májusban ");
                Console.WriteLine(majusiCsatlakozás? "volt csatlakozás" : "nem volt csatlakozás");

            //7. feladat
            var legregebbiDatum = new DateTime(1900, 1, 1);
            string keresettOrszag = "";
            for (int i = 0; i < N; i++)
            {
                if (tagallamok[i].getCsatlakozasDatuma() > legregebbiDatum)
                {
                    legregebbiDatum = tagallamok[i].getCsatlakozasDatuma();
                    keresettOrszag = tagallamok[i].getOrszag();
                }
            }
            Console.WriteLine($"7. feladat: Leguoljára csatlakozott ország: {keresettOrszag} ");

            Console.ReadLine();
        }
    }
}
