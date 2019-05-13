using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_04.rekursija
{
    class Program
    {
        public static int CalculateSumRecursively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateSumRecursively(n, m);
            }

            return sum;
        }

        static void Main(string[] args)
        {            
            int n = 1;
            int m = 3;

            int sum = CalculateSumRecursively(n, m);
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
