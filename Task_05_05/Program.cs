using System;

namespace Task_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение
случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
по следующему правилу:
• Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
• Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом*/
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число m");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(-99, 100); 
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = Math.Abs(matrix[i, j]);
                    }
                    else if (matrix[i, j] == 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            Console.WriteLine("Преобразованный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < 0) 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(matrix[i, j] + "\t");
                    }
                    else if (matrix[i, j] == 1) 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(matrix[i, j] + "\t");
                    }
                   else
                    {
                        Console.ResetColor();
                        Console.Write(matrix[i, j] + "\t");
                    }
                   
                }
                Console.WriteLine();
            }

        }
    }
}
