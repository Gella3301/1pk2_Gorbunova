namespace Task_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        { /*В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
мальчиков и девочек. При выводе избавиться от отрицательных значений.*/

            int[] heights = { 160, -170, 155, -180, 165, -175, 150, -165, 170, -160,
                          158, -172, 162, -168, 157, -173, 163, -167, 159, -171,
                          161, -169, 164, -166, 156, -174, 152, -176, 153, -177 };

            int boysCount = 0, girlsCount = 0;
            double boysHeight = 0, girlsHeight = 0;

            
            foreach (int height in heights)
            {
                if (height < 0) // Мальчики
                {
                    boysCount++;
                    boysHeight += Math.Abs(height); 
                }
                else // Девочки
                {
                    girlsCount++;
                    girlsHeight += height;
                }
            }

            
            Console.WriteLine($"Количество мальчиков: {boysCount}");
            Console.WriteLine($"Количество девочек: {girlsCount}");
            Console.WriteLine($"Средний рост мальчиков: {(boysCount > 0 ? boysHeight / boysCount : 0):F2} см");
            Console.WriteLine($"Средний рост девочек: {(girlsCount > 0 ? girlsHeight / girlsCount : 0):F2} см");
        }
    }
    
}
