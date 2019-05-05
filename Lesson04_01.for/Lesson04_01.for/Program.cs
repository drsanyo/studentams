using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson04_01.@for
{
    class Program
    {
        static void Main(string[] args)
        {
            // paprastas for cilkas
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // for ciklas priesinga krytimi
            for (int i = 10-1; i >= 10; i--)
            {
                Console.WriteLine(i);
            }


            // for ciklas su nestandartiniu zingsniu
            for (int i = 0; i < 10; i+=2)
            {
                Console.WriteLine(i);
            }


            // ... iteracijos per simbolių diapazoną.
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine(c);
            }


            // ciklas cikle ir vardu klaidos
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("i:{0}, j:{1}", j, i);
                }
            }


            // itecija per stringa
            string vardas = "C#Kursas";
            for (int i = 0; i < vardas.Length; i++)
            {
                char current = vardas[i];
                System.Console.WriteLine(current);
            }


            // progress bar
            for (int i = 0; i < 50; i++)
            {
                // reikia pridėti using System.Threading;
                Thread.Sleep(50); // milisekundes
                System.Console.Write("#");
            }
            Console.WriteLine();
            Console.WriteLine("Pabaiga");


            // amzinasis ciklas

            for (; ; )
            {
                Console.Write("?");
                break;
            }
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
