﻿namespace Task_33_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDrawable> list = new List<IDrawable>
           {
               new Circle(3),
               new Square(4,7),
               new Circle(10),
               new Rectangle(12)
           };

            foreach (var item in list)
                item.Draw();
        }
    }
}
