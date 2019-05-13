using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_03.perkrovimas
{
    class Program
    {
        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {

            int result = Sum(100, 23);
            Console.WriteLine(result);

            //double result = Sum(100, 23.45);
            //Console.WriteLine(result);

            Console.ReadLine();
            //Apziurime metodo WriteLine variantus            
        }
    }
}
