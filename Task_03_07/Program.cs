﻿namespace Task_03_07
{
    using System;

    class Program
    {
        static void Main()
        {
            /*Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g t ,
где 2 g = 9,8 м/с2 – ускорение свободного падения.*/
            double g = 9.8;

            
            Console.WriteLine("Время (с)| Скорость (м/с)");
            Console.WriteLine("--------------------------");
            
            for (double t = 0; t <= 10; t += 0.5) 
            {
                double v = g * t; 
                Console.WriteLine($"{t}\t  {v}");
            }
        }
    }
}