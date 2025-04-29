using static Task_32_01.Kolobok;

namespace Task_32_01
{
    internal class Program
  { 
        static void Main(string[] args)
        {
            Kolobok kolobok = new Kolobok();
            List<Animal> animals = new List<Animal>
{
new Hare(),
new Wolf(),
new Bear(),
new Fox()
};
            List<Obstacle> obstacle = new List<Obstacle>
{
new Rock(),
new Abyss(),

};
            foreach (var animal in animals)
            {
                if (!kolobok.IsAlive)
                    break;
                kolobok.Roll();
                kolobok.MeetAnimal(animal);
                foreach (var obstacles in obstacle)
                {
                    if (!kolobok.CanMove)
                    break;
                    kolobok.Roll();
                    kolobok.MeetObstacle(obstacles);
                       
                }
            }
          if (kolobok.IsAlive )
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
                
            }

        }
    }
}

