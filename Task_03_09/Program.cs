namespace Task_03_09
{
    using System;

    class Program
    {
        static void Main()
        {
            /*Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
менее y рублей.
Примеры
входные данные
100
10
200
выходные данные
8 */
            Console.Write("Введите начальную сумму вклада : ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите процентную ставку : ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Введите целевую сумму : ");
            double y = double.Parse(Console.ReadLine());

            int years = 0; 
          
            while (x < y)
            {
                x += x * (p / 100); 
                 
                years++;            
            }

           
            Console.WriteLine( years);
        }
    }
}
