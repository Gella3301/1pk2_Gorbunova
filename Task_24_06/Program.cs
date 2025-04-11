namespace Task_24_06
{
    internal class Program
    { /*Напишите метод, который принимает путь к файлу и возвращает количество строк в нем. Используйте StreamReader.*/
        static void Main(string[] args)
        {
            string filePath = "text.txt";
            int lines = CountLinesInFile(filePath);
            Console.WriteLine($"Количество строк в файле: {lines}");
        }
        public static int CountLinesInFile(string filePath)
        {
            int lineCount = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            return lineCount;
        }
    }
}
