namespace Task_21_08
{ /*напишите метод, который на вход получается массив параметров (строк) и возвращает только уникальные строки*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] list = { "apple", "orange", "apple", "banana", "orange", "mango", "apple" };
            string[] uniqueStrings = GetUniqueStrings(list);

            Console.WriteLine(string.Join(", ", uniqueStrings));
        }
        public static string[] GetUniqueStrings(string[] inputArray)
        {
            if (inputArray == null)
                return Array.Empty<string>();

            List<string> result = new List<string>();

            foreach (string item in inputArray)
            {
                if (!result.Contains(item)) 
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }
}
