using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; }
        public bool IsAlive { get; private set; }
        public bool CanMove { get; private set; }
        public Kolobok()
        {
            Position = 0;
            Speed = 1;
            IsAlive = true;
            CanMove = true;
        }

        public void Roll()
        {
            Position += Speed;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}");
        }
        public void MeetAnimal(Animal animal)
        {
            if (animal.CanEat(this))
            {
                IsAlive = false;
                Console.WriteLine($"Колобок был съеден {animal.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {animal.Name}!");
            }
        }
        public void MeetObstacle(Obstacle obstacle)
        {
            if (obstacle.CanStop(this))
            {
                CanMove = false;
                Console.WriteLine($"Колобок остановился у {obstacle.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок преодолел {obstacle.Name} катится дальше !");
            }
        }

        public class Hare : Animal
        {
            public Hare() : base("Заяц") { }
            public override bool CanEat(Kolobok kolobok)
            {
                return false;
            }
        }
        public class Rock : Obstacle
        {
            public Rock() : base("Камень") { }
            public override bool CanStop(Kolobok kolobok)
            {
              
                return false; 
            }
        }
        public class Wolf : Animal
        {
            public Wolf() : base("Волк") { }
            public override bool CanEat(Kolobok kolobok)
            {
                return false;
            }
        }
        public class Bear : Animal
        {
            public Bear() : base("Медведь") { }
            public override bool CanEat(Kolobok kolobok)
            {
                return false;
            }
        }
        public class Abyss : Obstacle
        {
            public Abyss() : base("Пропасть") { }
            public override bool CanStop(Kolobok kolobok)
            {
                return true;
            }
        }

            public class Fox : Animal
        {
            public Fox() : base("Лиса") { }
            public override bool CanEat(Kolobok kolobok)
            {
                return true;
            }
        }
      
    }
}
