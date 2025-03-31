using System.Drawing;

namespace Task_20_06
{
    internal class Program
    { /*Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
• Red
• Yellow
• Green
Реализуйте автоматическое переключение цветов (каждые 3 секунды). При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep). Добавьте возможность ручного переключения (например, по нажатию клавиши).*/
        static void Main(string[] args)

        {
            Color light = Color.Red;

            while (true)
            {
                
                Console.Clear();
                Console.ForegroundColor = light switch
                {
                    Color.Red => ConsoleColor.Red,
                    Color.Yellow => ConsoleColor.Yellow,
                    _ => ConsoleColor.Green
                };
                Console.WriteLine($"Светофор: {light}");
                Console.ResetColor();

              
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true); 
                }
                else
                {
                    Thread.Sleep(3000);
                }

               
                light = light switch
                {
                    Color.Red => Color.Yellow,
                    Color.Yellow => Color.Green,_
                     => Color.Red
                };
            }
        }
    }




}



