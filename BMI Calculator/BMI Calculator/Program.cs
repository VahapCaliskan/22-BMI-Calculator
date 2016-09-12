using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ALLE EINGABEN MIT KOMMA TÄTIGEN!!!");
            Console.WriteLine("Bsp.: Körpergröße 1,75 & Gewicht 80,2\n");
            Console.WriteLine("Bitte gebe deine Koerpergroesse in Metern ein (ohne m):");
            double dHeight = Double.Parse(Console.ReadLine());
            Console.WriteLine("Bitte gebe dein Gewicht in Kilogramm an (ohne kg):");
            double dWeight = Double.Parse(Console.ReadLine());
            Console.WriteLine("Dein BMI beträgt:" + (dWeight / (dHeight * dHeight)).ToString());
            Console.Read();
        }
    }
}
