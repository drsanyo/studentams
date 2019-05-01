using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_08.switchPaprastas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koki veiksma norite atlikti?");
            Console.WriteLine("[1] - istrinti vartotoja, [2] - sukurti vartotoja, [3] - redaguoti esama");

            int veiksmas = int.Parse(Console.ReadLine());

            switch (veiksmas)
            {
                case 1:
                    Console.WriteLine("vartotojas sekmingai istrintas...");
                    break;
                case 2:
                    Console.WriteLine("vartotojas sekmingai sukurtas...");
                    break;
                case 3:
                    Console.WriteLine("Vartotojo redagavimo rezimas...");
                    break;
                default:
                    Console.WriteLine("Nezinomas veiksmas. Paspauskite [ENTER] kad uzdarytymet langa.");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine("Paspauskite [ENTER] kad uzdarytymet langa.");
            Console.ReadLine();
        }
    }
}
