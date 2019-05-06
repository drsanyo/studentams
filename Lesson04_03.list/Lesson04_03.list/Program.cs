using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_03.list
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> savaitesDienos = new List<string>();
            //List<int> skaiciai = new List<int>();
            savaitesDienos.Add("pirmadienis");
            savaitesDienos.Add("antradienis");
            savaitesDienos.Add("trečiadienis");
            savaitesDienos.Add("ketvirtadienis");
            savaitesDienos.Add("penktadienis");
            savaitesDienos.Add("šeštadienis");
            savaitesDienos.Add("sekmadienis");
            */

            // saraso uzpildymas
            /*
            List<string> saliuSarasas = new List<string>();
            // reikia using System.IO;
            using (StreamReader saliuFailas = new StreamReader("countries.txt"))
            {
                string nuskaitytaEilute;
                while ((nuskaitytaEilute = saliuFailas.ReadLine()) != null)
                {
                    saliuSarasas.Add(nuskaitytaEilute);
                }
            }

            for (int i = 0; i < saliuSarasas.Count; i++)
            {
                Console.WriteLine(saliuSarasas[i]);
            }
            Console.WriteLine("Is viso: {0} saliu", saliuSarasas.Count);
            */


            // iterpti itrinti elementa
            /*
            List<int> menesioDienos = new List<int>();
            menesioDienos.Add(1);
            menesioDienos.Add(2);
            menesioDienos.Add(3);
            menesioDienos.Add(4);
            menesioDienos.Add(29);
            menesioDienos.Add(30);
            menesioDienos.Add(31);

            Console.WriteLine("Pries:");
            foreach (int diena in menesioDienos)
            {
                Console.WriteLine(diena);
            }
            Console.WriteLine("");

            int trukstamaDiena = 5;
            int index = menesioDienos.FindIndex(diena => diena > trukstamaDiena);
            menesioDienos.Insert(index, trukstamaDiena);
            //removeAt

            Console.WriteLine("Po");
            foreach (int diena in menesioDienos)
            {
                Console.WriteLine(diena);
            }
            */
            Console.ReadLine();
        }
    }
}
