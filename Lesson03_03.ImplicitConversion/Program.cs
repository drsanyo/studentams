using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_03.ImplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 57;
            int i = b;
            long l = i;
            float f = l;

            // Display Result
            Console.WriteLine("Byte value:  " + b);
            Console.WriteLine("Int value:   " + i);
            Console.WriteLine("Long value:  " + l);
            Console.WriteLine("Float value: " + f);

            Console.ReadLine();
        }
    }
}
