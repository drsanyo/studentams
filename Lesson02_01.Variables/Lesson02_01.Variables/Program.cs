using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_01.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearOfBirth = 1990;
            string firstName = "Vardenis";
            var lastName = "Pavardenis";
            decimal salary = 1999.9m;
            DateTime lastPayDay = DateTime.Today.AddMonths(-1);

            Console.WriteLine("Vardas, Pavarde: {0}, {0}",
                firstName, lastName);
            Console.WriteLine("Gimimo metai: {0}", yearOfBirth);
            Console.WriteLine("Pajamos: {0}", salary);
            Console.WriteLine("Paskutini karta ismoketa alga: {0}",
                lastPayDay.ToLongDateString());

            Console.ReadLine();
        }
    }
}
