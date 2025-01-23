namespace Task_03_06
{
    internal class Program
    { 
        static void Main(string[] args)
        {/* Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5*/
            Console.WriteLine("    x\t | y = |x|" );
            Console.WriteLine("-------------------");
            for (double x = -4; x <= 4; x += 0.5)
            {
                double y = Math.Abs(x); 
                Console.WriteLine($"{x}\t |   {y}");
            }
        }
    }
}
