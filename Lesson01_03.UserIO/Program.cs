using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_03.UserIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "";
            while (vardas != "stop")
            {
                Console.WriteLine("Iveskite savo varda:");
                vardas = Console.ReadLine();
                Console.WriteLine("Sveiki {0} [ENTER - testi]", vardas);
            }

            Console.Clear();
            Console.WriteLine("Ate...");
            Console.ReadLine();
        }
    }
}
