namespace Task_10_06
{
    internal class Program
    { /*Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n, выводит на консоль сгенерированный массив размерности n*n.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());
            ArrayGeneration(n);
            
        }
        static void ArrayGeneration(int n)
        { 
            int [,] array = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                { 
                    array[i, j] = rnd.Next(1,100);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
