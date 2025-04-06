namespace Task_21_06
{
    internal class Program
    { /*Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок*/
        static void Main(string[] args)
        {
            var items = new List<int> { 1, 2, 2, 3, 1, 2, 4, 7, 1 };
            var uniqueItems = RemoveDuplicates(items);

            foreach (var num in uniqueItems)
                Console.Write(num + " "); 

            Console.WriteLine(); 
        }
        
     
        public static List<int> RemoveDuplicates(List<int> list)
        {
            var unique = new HashSet<int>();
            var result = new List<int>();

            foreach (var item in list)
                if (unique.Add(item))
                    result.Add(item);
            return result;
        }
    }
}
