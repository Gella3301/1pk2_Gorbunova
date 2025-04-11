namespace Task_24_07
{
    internal class Program
    { /*Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки, содержащие это слово (регистронезависимо).*/
        static void Main()
        { 
            string  filePath = "text.txt";

            Console.WriteLine("Введите слово, которое нужно найти");
            string searchWord = Console.ReadLine();

            foreach (string line in FindLines(filePath, searchWord))
            {
                Console.WriteLine(line);
            }
        }


        static List <string> FindLines(string filePath, string word)
        {
            List<string> result = new List<string>();

            foreach (string line in File.ReadAllLines(filePath))
            {
                if (line.Contains(word, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(line);
                }
            }

            return result;
        }
    }
}
