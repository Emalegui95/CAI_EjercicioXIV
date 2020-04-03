using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mult = 1;
            int resultado = 0;

            Console.WriteLine("Ingrese un número del 1 al 9");
            int num = int.Parse(Console.ReadLine());

            while (num > 9)
            {
                Console.WriteLine("Ingrese un número del 1 al 9");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La tabla de multiplicación del " + num + " es: ");

            while (mult <= 10)
            {
                resultado = num * mult;
                Console.WriteLine(num + " x " + mult + " = " + num * mult);
                mult++;
            }

            Console.ReadKey();
        }
    }
}

