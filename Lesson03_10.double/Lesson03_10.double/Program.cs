using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_10.@double
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaicius1 = 0.1 * 10;
            double skaicius2 = 0;

            for (int ctr = 0; ctr < 10; ctr++)
            {
                skaicius2 += 0.1;
            }

            Console.WriteLine("{0:R} = {1:R} : {2}",
                skaicius1, skaicius2, skaicius1==skaicius2);
            Console.ReadLine();
        }
    }
}
