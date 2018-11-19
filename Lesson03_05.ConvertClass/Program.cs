using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_05.ConvertClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            double d = 765.12;
            float f = 56.123F;

            Console.WriteLine("ToString(f): " + Convert.ToString(f));
            Console.WriteLine("ToInt32(d): " + Convert.ToInt32(d));
            Console.WriteLine("ToUInt32(f): " + Convert.ToUInt32(f));
            Console.WriteLine("ToDouble(i): " + Convert.ToDouble(i));

            Console.ReadLine();
        }
    }
}
