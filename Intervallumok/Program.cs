using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervallumok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kedves Felhasználó! Adj meg egy intervallumot!");
            string nyersintervallum = Console.ReadLine();
            string[] tomb = nyersintervallum.Split(';'); // darabold fel a szöveget a ;-k mentén

            /** /
            Console.WriteLine("tomb[0] : " + tomb[0]);
            Console.WriteLine("tomb[1] : " + tomb[1]);
            /**/

            char balkereteszarojel = tomb[0][0];
            char jobbkereteszarojel = tomb[1][tomb[1].Length-1];

            string balszamszoveg = tomb[0].Substring(1);// 1. indextől hátrafele a string
            int balszam = int.Parse(balszamszoveg);
            string jobbszamszoveg = tomb[1].Substring(0,tomb[1].Length-1); // 0-ás index = 1. elemtől hossz-1-nyit vegyél
            int jobbszam = int.Parse(jobbszamszoveg);


            /** /
            Console.WriteLine("Az inputot így értelmeztem:");

            Console.WriteLine(balkereteszarojel);
            Console.WriteLine(balszam);
            Console.WriteLine(jobbszam);
            Console.WriteLine(jobbkereteszarojel);
            /**/

            // Ide le írjátok majd a kódot!
            /* ezek a változók, amiket használni kell:  
             * balszam, 
             * jobbszam, 
             * balkereteszarojel, 
             * jobbkereteszarojel
             */














        }
    }
}
