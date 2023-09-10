using System;

namespace PZ_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = Math.PI;
            double c = 0;

            double result = (Math.Pow(3 * Math.Log(Math.Pow(a, 8)), 1.0 / 3)) / (Math.Sin(b / (3 * a)))
            - Math.Pow(5 * Math.Pow(a, 2) + 7, 1.0 / 3) + (4 * Math.Abs(c - 2 * a + 1)) / Math.Sqrt(8 * a);

            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}