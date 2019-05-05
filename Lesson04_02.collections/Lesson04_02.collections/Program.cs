using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_02.collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pirmadienis = "pirmadienis";

            string[] savaitesDienos = {
                "pirmadienis",
                "antradienis",
                "trečiadienis",
                "ketvirtadienis",
                "penktadienis",
                "šeštadienis",
                "sekmadienis"
            };


            // ejimas per masyva
            /*
            for (int i = 0; i < savaitesDienos.Length; i++)
            {
                Console.WriteLine(savaitesDienos[i]);
            }
            */

            // elemento paemimas
            /*
            Console.WriteLine("Kuria savaites diena parodyti?");
            Console.WriteLine("Pirmadienis - 1 ir tt.");

            int index = int.Parse(Console.ReadLine());

            string pasirinktaDiena = savaitesDienos[index];
            Console.WriteLine("Pasirinkta diena yra {0}", pasirinktaDiena);
            */

            /*
            // elemento keitimas
            Console.WriteLine("Pries:");
            foreach (var diena in savaitesDienos)
            {
                Console.WriteLine(diena);
            }

            savaitesDienos[2] = "TRECIADIENIS";

            Console.WriteLine("");
            Console.WriteLine("Po:");
            foreach (var diena in savaitesDienos)
            {
                Console.WriteLine(diena);
            }
            */


            // daugiamaciai masyvai
            /*
            int[,] matrica = new int[5, 4]
            {
                { 1, 1, 1, 1 },
                { 0, 1, 1, 1 },
                { 0, 0, 1, 1 },
                { 0, 0, 0, 1 },
                { 0, 0, 0, 0}
            };
            for (int x = 0; x <= matrica.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= matrica.GetUpperBound(1); y++)
                {
                    Console.Write(matrica[x, y]);
                }
                Console.WriteLine("");
            }
            */


            // masyvo uzpildymas atsitiktiniais skaiciais
            /*
            int[] skaiciai = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = rnd.Next(1, 100);
            }
            foreach (var skaicius in skaiciai)
            {
                Console.Write("{0}, ", skaicius);
            }
            */

            int[] skaiciai = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = rnd.Next(1, 100);
            }

            for (int i = 0; i < skaiciai.Length; i++)
            {
                for (int j = 0; j < skaiciai.Length; j++)
                {
                    if (skaiciai[i] < skaiciai[j])
                    {
                        var k = skaiciai[i];
                        skaiciai[i] = skaiciai[j];
                        skaiciai[j] = k;

                    }
                }
            }

            foreach (var skaicius in skaiciai)
            {
                Console.Write("{0}, ", skaicius);
            }

            Console.ReadLine();
        }
    }
}
