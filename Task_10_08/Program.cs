namespace Task_10_08
{
    /*Создайте метод, который на вход принимает одномерный массив и число для поиска, верните индекс искомого элемента в массиве. Если элемента нет – верните индекс = -1*/
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 5, 7 };
            int target = 5;

            int index = FindIndex(array, target);

            if (index != -1)
            {
                Console.WriteLine($"Элемент {target} найден по индексу {index}.");
            }
            else
            {
                Console.WriteLine($"Элемент {target} не найден, индекс {index}.");
            }
        }
        /// <summary>
        /// метод выполняет поиск элемента в массиве
        /// </summary>
        /// <param name="array">массив, в котором нужно искать элемент </param>
        /// <param name="target">элемент, который должен быть найден </param>
        /// <returns></returns>

        static int FindIndex(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
