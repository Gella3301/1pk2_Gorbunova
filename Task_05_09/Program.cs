namespace Task_05_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей
(это матрица, где все недиагональные элементы меньше нуля)
Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали. Если не выполняется, то
вывести сообщение что данная матрица не является Z-матрицей */
            Console.Write("Введите размер матрицы (n): ");
            int n = int.Parse(Console.ReadLine());

            // Создание и заполнение матрицы
            int[,] matrix = new int[n, n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }


            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }


            bool zmatrix = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] >= 0)
                    {
                        zmatrix = false;
                        break;
                    }
                }
                if (!zmatrix) 
                    break;
            }

            if (zmatrix)
            {
                Console.WriteLine("\nМатрица является Z-матрицей. Главная диагональ выделена:");
                Console.Write(matrix);
            }
            else
            {
                Console.WriteLine("\nМатрица не является Z-матрицей.");
            }

            int a = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }


            int b = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; 
                        Console.Write(matrix[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
        
    

