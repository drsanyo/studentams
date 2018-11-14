using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_01.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 0;

            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            a = 254;

            a++;
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
