namespace Task_03_05
{ 
    using System;

    class Program
    {
        static void Main()
        { /* Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
время работы программы*/


            Console.WriteLine("Введите начальную температуру");
            double t1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конечную температуру");
            double t2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг изменения температуры");
            double step = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Цельсия | Фаренгейт");
            Console.WriteLine("-------------------");

          
            for (double celsius = t1; celsius <= t2; celsius += step)
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius}\t{fahrenheit}");
            }
        }
    }
}

