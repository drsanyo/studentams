﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;

            Console.WriteLine("a:{0}, b:{1}", a, b);

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a:{0}, b:{1}", a, b);

            Console.ReadLine();

        }
    }
}
