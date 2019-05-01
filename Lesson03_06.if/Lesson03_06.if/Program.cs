using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_06.@if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite grupes pavadinima:");
            string grupesPavadinimas = Console.ReadLine();

            Console.WriteLine("Iveskite grupes nariu skaiciu:");
            int nariuSkaicius = 0;

            if (!int.TryParse(Console.ReadLine(), out nariuSkaicius))
            {
                Console.WriteLine("Ivestas nekorektiskas skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Grupes pavadinimas yra: {0}, nariu skaicius yra {1}",
                grupesPavadinimas, nariuSkaicius);
            Console.ReadLine();
        }
    }
}
