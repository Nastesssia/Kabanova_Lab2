using System;

namespace Kabanova_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double C, L, U, I, W;
                Console.WriteLine("Введите C:");
                C = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите L:");
                L = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите U:");
                U = double.Parse(Console.ReadLine());
                Console.WriteLine("C={0} Ф",C);
                Console.WriteLine("L={0} Гн", L);
                Console.WriteLine("U={0} В", U);
                I = U * Math.Sqrt(C / L);
                W = L * I * I / 2;
                Console.WriteLine("I={0:F2} А", I);
                Console.WriteLine("W={0:F2} Дж", W);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
