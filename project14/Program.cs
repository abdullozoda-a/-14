using System;
using Console = System.Console;

namespace project14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double Summa = 0;
            for (int i=1; i<=n; i++)
            {
                Summa += 1.0 / i;
            }
            Console.WriteLine(Summa);
        }
    }
}