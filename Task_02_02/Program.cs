namespace Task_02_02
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            /* Найти значение выражения при a = 8, b = 14, с = π/4*/
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;

            double a1 = a - 1;
            double part1 = Math.Pow(b, 0.25) + Math.Pow(a1, 1.0 / 3.0);
            double sinc = Math.Sin(c);
            double part2 = Math.Abs(a - b) * (Math.Pow(sinc, 2) + Math.Tan(c));
            double part3 = part1 / part2;

            Console.WriteLine(part3);

        }
    }
}