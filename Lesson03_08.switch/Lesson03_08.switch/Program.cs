using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_08.@switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite temperatura:");
            int temperatura = int.Parse(Console.ReadLine());

            switch (temperatura)
            {
                case int val when val < 0:
                    Console.WriteLine("Esant normaliam slegiui vanduo tokioje temperatūroje uzsala");
                    break;
                case int val when (val > 0) && (val < 99) :
                    Console.WriteLine("Esant normaliam slegiui vanduo tokioje temperatūroje neverda");
                    break;
                case int val when (val > 100):
                    Console.WriteLine("Esant normaliam slegiui vanduo tokioje temperatūroje uzverda");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
