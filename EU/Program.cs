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
           
            
        }
    }
}
