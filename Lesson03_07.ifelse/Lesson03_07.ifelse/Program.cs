using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_07.ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite spalva:");
            string spalva = Console.ReadLine();

            if ((spalva == "geltona") || (spalva == "zalia") || (spalva == "raudona"))
                Console.WriteLine("{0} - tai spalva is trispalves", spalva);
            else
                Console.WriteLine("{0} - spalva spalva nepriklauso trispalvei", spalva);

            Console.ReadLine();
        }
    }
}
