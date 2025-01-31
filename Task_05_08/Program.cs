namespace Task_05_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. Создать новый массив, который будет
произведением двух предыдущих (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
результирующий массив)
Вывести результирующий массив */
            int size12 = 10;
            int[,] matrix1 = new int[size12, size12];
            int[,] matrix2 = new int[size12, size12];
            Random rnd = new Random();
            for (int i = 0; i < size12; i++)
            {
                for (int j = 0; j < size12; j++)
                {
                    matrix1[i, j] = rnd.Next(1, 10);
                    matrix2[i, j] = rnd.Next(1, 10);
                }
            }
            Console.WriteLine("Первый массив :");
            for (int i = 0; i < size12; i++)
            {
                for (int j = 0; j < size12; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }
                Console.WriteLine("Второй массив :");
            for (int i = 0; i < size12; i++)
            {
                for (int j = 0; j < size12; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }

                 int[,] mult = new int[size12, size12];

                for (int i = 0; i < size12; i++)
                {
                    for (int j = 0; j < size12; j++)
                    {
                        mult[i, j] = matrix1[i, j] * matrix2[i, j];
                    }

                }
            Console.WriteLine("Результирующий массив :");
            for (int i = 0; i < size12; i++)
            {
                for (int j = 0; j < size12; j++)
                {
                    Console.Write(mult[i, j] + "\t");
                }
                Console.WriteLine();
            }






        }
    }
}
    

