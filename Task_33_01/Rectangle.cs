using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_33_01
{

    internal class Rectangle : IDrawable
    {

        private int length;
        public int Length
        {
            get => length;
            set
            {
                if (value > 1)
                    length = value;
                else
                    throw new ArgumentException("Длина катетов не должна быть меньше или равна 1");
            }
        }

        public Rectangle(int length)
        {
            Length = length;
        }

        public void Draw()
        {
            Console.WriteLine();
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
