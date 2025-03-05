using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_10_07
{
    internal class Program
    { /*Создайте метод с помощью которого можно сгенерировать и вернуть символьный двумерныймассив(состоящийиз символов русского алфавита) и выведите на консоль данный массив с помощью другого метода(который принимает данный массив в качестве параметра*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());
            AlphabetGeneration(n);
           
        }
        /// <summary>
        /// метод генерирует буквенный массив 
        /// </summary>
        /// <param name="n"> размер массива</param>
        
        static void AlphabetGeneration(int n)
        {
            char[,] array = new char[n, n];
            Random rnd = new Random();
            string RussianAlphabet = "";
            for (char c = 'А'; c <= 'Я'; c++)
            {
                RussianAlphabet += c;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        array[i, j] = RussianAlphabet[rnd.Next(RussianAlphabet.Length)];
                    }
                }



                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                static void PrintArray(char[,] array)
                {
                    int n = array.GetLength(0); 

                    Console.WriteLine("Сгенерированный массив:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(array[i, j] + "\t"); 
                        }
                        Console.WriteLine(); 
                    }
                }

            }

        }
    }
}
