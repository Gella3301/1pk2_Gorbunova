﻿namespace Task_03_08
{
    using System;

    class Program
    { 
        static void Main(string[] args)
        {
            //Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5. 
            for (int number = 20; number <= 50; number++)
            {
                
                if (number % 3 == 0 && number % 5 != 0)
                {
                    Console.WriteLine(number); 
                }
            }
        }
    }
}
