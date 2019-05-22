using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson08_01.BookStruct;

namespace Lesson08_01.library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book knyga;
            knyga.Name = "vardas";
            knyga.Id = "0123";

            Console.WriteLine(knyga.LocalId);
            Console.ReadLine();
        }
    }
}
