using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacija;
            double broj1;
            double broj2;
            double pom;


            Console.Write("Unesite operaciju(+,-,*,/)>");
            operacija = Console.ReadLine();
            Console.Write("Unesite prvi broj>");
            broj1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unesite drugi broj>");
            broj2 = Convert.ToDouble(Console.ReadLine());

            if (((operacija == "-") || (operacija == "/")) & (broj2 > broj1))
            {
                pom = broj1;
                broj1 = broj2;
                broj2 = pom;
            }

            double rezultat = Zadatak2.Op2Numb(operacija, broj1, broj2);
            Console.WriteLine("Rezultat operacije {0} {1}{2}={3}", broj1, operacija, broj2, rezultat);



            Console.ReadKey();

        }
    }
}
