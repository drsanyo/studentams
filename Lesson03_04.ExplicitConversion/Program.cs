using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_04.ExplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int a = 15;

            bool result = ((x % 2) == 0) && ((x % 2) == 0);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
