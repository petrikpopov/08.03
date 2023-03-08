using System;
using System.Linq;
namespace _08._03._2023HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            int[] mass = { 1, 2, 3, 4, 4, 4, 7, 8, 9 };
            int[] mass1 = { 4, 2, 3, 5, 6, 8, 4, 1, 0 };

            var R = mass.Except(mass1);
            foreach (var i in R)
            {
                Console.WriteLine("Разность массивов -->"+i);
            }
            Console.WriteLine("\n");

            var R1 = mass.Intersect(mass1);
            foreach(var i in R1)
            {
                Console.WriteLine("Общие элименты -->"+i);
            }
            Console.WriteLine("\n");

            var R2 = mass.Union(mass1);
            foreach (var i in R2)
            {
                Console.WriteLine("Общие элименты без дублирования -- > "+i);
            }
            Console.WriteLine("\n");

            var R4 = mass.Distinct();
            foreach (var i in R4)
            {
                Console.WriteLine("Содержимое первого массива без повтора"+i);
            }
        }
    }
}
