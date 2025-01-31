using System;

namespace Task_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Осуществить генерация двумерного [10*5] массива по следующему правилу:
 • 1 столбец содержит нули
 • 2 столбце содержит числа кратные 2
 • 3 столбец содержит числа кратные 3
 • 4 столбец содержит числа кратные 4
 • 5 столбец содержит числа кратные 5
 Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив */
            int row = 10;
            int col = 5;

            
            int[,] matrix1 = new int[row, col];
            Random rnd = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j == 0)
                    {
                        matrix1[i, j] = 0;
                    }
                    else
                    {
                        matrix1[i, j] = rnd.Next(1, 100) * (j + 1);
                    }
                }
            }

            
            Console.WriteLine("Первоначальный массив :");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] tmat = new int[col, row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    tmat [j, i] = matrix1[i, j];
                }
            }

            Console.WriteLine("\nПеревернутый  массив:");
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(tmat[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
            



        
    }
            
            
        
  
}
