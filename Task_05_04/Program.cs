namespace Task_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
диагональной (все элементы вне главной диагонали равны нулю)
Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
сообщение что матрица не является диагональной*/

            int[,] matrix1 = {
            { 4, 0, 0 },
            { 0,-1, 0 },
            { 0, 0, 43}
           };

            int n = matrix1.GetLength(0);

            bool Diagonal = true;

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix1[i, j] != 0)
                    {
                        Diagonal = false;
                        break;
                    }
                }
                if (!Diagonal) break;
            }

            if (Diagonal)
            {
                Console.WriteLine("Матрица является диагональной:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue; 
                            Console.Write(matrix1[i, j] + "\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matrix1[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной.");
            }
        }
    }
}
