using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter first number; second number
            Console.WriteLine("Iveskite pirma skaiciu");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            int nr2 = int.Parse(Console.ReadLine());
            int nr3 = nr1 + nr2;
            Console.WriteLine("Jusu skaiciai {0} , {1} ir ju suma {2}", nr1, nr2, nr3);
            Console.ReadLine();
        }
    }
}
