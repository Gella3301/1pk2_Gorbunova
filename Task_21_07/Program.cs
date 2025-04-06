namespace Task_21_07
{
    internal class Program
    { /*Написать метод, который находит первый ключ в словаре, соответствующий заданному значению. Если значения нет, вернуть null*/
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>()
        {
            { 1, "Мандарин" },
            { 2, "Банан" },
            { 3, "Апельсин" },
            { 4, "Банан" },
            { 5, "Яблоко" },
        };

           
            int? foundKey1 = FindKeyByValue(dictionary, "Банан");
            int? foundKey2 = FindKeyByValue(dictionary, "Дыня");

            if (foundKey1 != null)
                Console.WriteLine($"Найден ключ: {foundKey1}");  
            else
                Console.WriteLine("Значение не найдено");

            if (foundKey2 != null)
                Console.WriteLine($"Найден ключ: {foundKey2}");
            else
                Console.WriteLine("Значение не найдено");
        }
        public static int?  FindKeyByValue(Dictionary<int, string> dict, string value)
        {
            if (dict == null)
                return null;

            foreach (var item in dict)
            {
                if (item.Value == value)
                    return item.Key;
            }

            return null;
        }
    }
}
