namespace Task_03_04
{
    using System;

    public class TextCounter
    {
        public static void Main(string[] args)
        { 
            /*Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается. Когда
пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
введенных пользователем.*/

            int count = 0;
            string input;

            while (true)
            {
                Console.Clear();
                Console.Write("Введите текст (или enter /exit): ");
                input = Console.ReadLine(); 

                if (string.IsNullOrEmpty(input) || input == "exit")
                {
                    break; 
                }

                count++;
            }

            Console.WriteLine($"\nВы ввели {count} строк.");
        }
    }
}
