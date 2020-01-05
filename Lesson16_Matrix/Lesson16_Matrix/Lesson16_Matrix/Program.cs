using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson16_Matrix
{
    class Program
    {
        private static ConsoleColor SimbolioSpalva = ConsoleColor.Green;
        private static int SimboliuKiekis = (int)(Console.WindowWidth * 6.0);
        private static int DidziausiasGreitis = 4;
        private static int MaziausiasGreitis = 1;
        private static List<Simbolis> Simboliai = new List<Simbolis>();
        private static int PiesimoUzlaikymas = 10000 / SimboliuKiekis; // kuo daugiau simboliu, tuo mazesnis uzlaikymas
        static void Main(string[] args)
        {   
            
            Random rnd = new Random();

            SugeneruotiPradiniusSimbolius();
            
            PiestiPradineSimboliuPozicija();

            while (!Console.KeyAvailable)
            {
                foreach (var simbolis in Simboliai)
                {
                    TrintiNupiestaSimboli(simbolis);

                    //simbolis.Zenklas = AtsitiktinisSimbolis();
                    simbolis.Y += simbolis.Greitis;
                    if (simbolis.Y >= Console.WindowHeight)
                    {
                        simbolis.Y = 0;
                        simbolis.Zenklas = AtsitiktinisSimbolis();
                    }
                    simbolis.Greitis = rnd.Next(MaziausiasGreitis, DidziausiasGreitis);

                    PiestiNaujaSimboli(simbolis);
                }
                Thread.Sleep(PiesimoUzlaikymas);
            } 

            Console.ResetColor(); // To return colors back
        }

        private static void SugeneruotiPradiniusSimbolius()
        {
            Random rnd = new Random();
            for (int i = 0; i < SimboliuKiekis; i++)
            {                
                Simboliai.Add(new Simbolis()
                {
                    X = rnd.Next(Console.WindowWidth),
                    Y = 0,
                    Zenklas = AtsitiktinisSimbolis(),
                    Greitis = rnd.Next(MaziausiasGreitis, DidziausiasGreitis)
                });
                Thread.Sleep(1);
            }
        }

        private static void PiestiNaujaSimboli(Simbolis simbolis)
        {
            PiestiSimboli(simbolis, SimbolioSpalva);
        }
        
        private static void TrintiNupiestaSimboli(Simbolis simbolis)
        {
            PiestiSimboli(simbolis, ConsoleColor.Black);
        }

        private static void PiestiSimboli(Simbolis simbolis, ConsoleColor spalva)
        {
            Console.ForegroundColor = spalva;
            Console.SetCursorPosition(simbolis.X, simbolis.Y);
            Console.Write(simbolis.Zenklas);
        }


        private static void PiestiPradineSimboliuPozicija()
        {
            foreach (var simbolis in Simboliai)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(simbolis.X, simbolis.Y);
                Console.Write(simbolis.Zenklas);
            }
        }

        private static char AtsitiktinisSimbolis()
        {
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length - 1);
            return chars[num];
        }
    }    
}
