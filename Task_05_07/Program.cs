namespace Task_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе[n * n].Заполнение случайными
  числами в диапазоне от 10 до 99 включительно.
 Найти и вывести отдельно минимальный элемент в матрице(LINQ под запретом) Осуществить умножение матрицы на ее
 минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве*/
            Console.WriteLine("Введите ваше число n ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[n,n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix1[i, j] = rnd.Next(10, 100);
                }
            }
            Console.WriteLine( "Массив с исходными данными");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix1[i,j] + "\t" );
                }
                  Console.WriteLine();
            }

            int min = matrix1[0 , 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix1[i, j] < min)
                    {
                        min= matrix1[i, j];
                    }
                }
            }
            Console.WriteLine($"Минимальное число: {min}");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix1[i, j] *= min; 
                }
            }
            int[] five = new int[5];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (matrix1[i, j] > five[0])
                    {

                        five[0] = matrix1[i,j];
                        Array.Sort(five);
                    }
                }
            }
            Console.WriteLine("Умноженный массив :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix1[i, j] == five[0] || matrix1[i, j] == five[1] ||
                    matrix1[i, j] == five[2] || matrix1[i, j] == five[3] ||
                    matrix1[i, j] == five[4])
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
        
    }
}
