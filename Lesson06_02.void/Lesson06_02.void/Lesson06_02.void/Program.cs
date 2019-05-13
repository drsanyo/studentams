using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_02.@void
{
    class Program
    {
        static void Main(string[] args)
        {
            SkaiciusLangeluje(1);
            SkaiciusLangeluje(12);
            SkaiciusLangeluje(1123456);

            Console.ReadLine();
        }

        private static void SkaiciusLangeluje(int skaicius)
        {
            int kiekRemelioSimboliuNupiesti = 25;
            string remoSimbolis = "*";
            string tarpelioSimbolis = " ";
            
            // nupiesiame virsutine eilute            
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remoSimbolis);
            }
            Console.WriteLine();

            // nupiesiame vidurine eilute
            Console.Write("{0}{1}{2}", remoSimbolis, tarpelioSimbolis, skaicius);
            int skaiciausIlgis = skaicius.ToString().Length;
            int kiekTarpuPraleisti = remoSimbolis.Length*2 + skaiciausIlgis + tarpelioSimbolis.Length;
            for (int i = kiekTarpuPraleisti; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(tarpelioSimbolis);
            }
            Console.Write(remoSimbolis);

            // nupiesiame apatine eilute
            Console.WriteLine();
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remoSimbolis);
            }
            Console.WriteLine();

        }
    }
}
