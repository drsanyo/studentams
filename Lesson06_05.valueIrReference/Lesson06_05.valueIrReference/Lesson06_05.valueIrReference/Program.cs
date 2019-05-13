using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_05.valueIrReference
{
    class Program
    {
        private static void KieciameArgumentus(int skaicius1)
        {
            skaicius1 = skaicius1 + 10;
            Console.WriteLine("Pakeistas skaicius1: {0}", skaicius1);
        }

        /*
        private static void TikraiKieciameArgumentus(ref int skaicius1)
        {
            skaicius1 = skaicius1 + 10;
            Console.WriteLine("Pakeistas skaicius1: {0}", skaicius1);
        }
        */
        static void Main(string[] args)
        {
            int skaicius = 7;
            Console.WriteLine("Originalus skaicius: {0}", skaicius);
            KieciameArgumentus(skaicius);
            Console.WriteLine("Skaicius po keitimo: {0}", skaicius);

            Console.WriteLine("");
            /*
            Console.WriteLine("Originalus skaicius: {0}", skaicius);
            TikraiKieciameArgumentus(ref skaicius);
            Console.WriteLine("Skaicius po keitimo: {0}", skaicius);
            */
            Console.ReadLine();
        }
    }
}
