
namespace Task_13_02
{ /*создать класс питомца
свойства:
кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров)
методы:
вывод информации об объекте
изменение значения веса животного
изменение отметки о состоянии здоровья
конструкторы:
предусмотрите разные варианты */
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pet pet1 = new Pet(); 
            Pet pet2 = new Pet("Матроскин", "Кот", 3, 4.5, true); 
            Pet pet3 = new Pet("Шарик", "Собака", 2, 8.5, false); 

            
            Console.WriteLine("Информация о питомцах:");
            pet1.DisplayInfo();
            Console.WriteLine();
            pet2.DisplayInfo();
            Console.WriteLine();
            pet3.DisplayInfo();
            Console.WriteLine();

            pet2.UpdateWeight(2.0); 
            pet2.UpdateHealthStatus(false); 
            Console.WriteLine();

            
            Console.WriteLine("Обновленная информация о питомце 2:");
            pet2.DisplayInfo();
        }
        public class Pet
        {
            #region поля
            public string Name;
            public string Species;
            public int Age;
            public double Weight;
            public bool IsHealthy;
            #endregion

            public Pet()
            {
               
                Name = "Unknown";
                Species = "Unknown";
                Age = 0;
                Weight = 0.0;
                IsHealthy = true;
             
            }

            public Pet(string name, string species, int age, double weight, bool isHealthy)
            {
                Name = name;
                Species = species;
                Age = age;
                Weight = weight;
                IsHealthy = isHealthy;
            }

            public Pet(string name, string species)
            {
                Name = name;
                Species = species;
                Age = 0; 
                Weight = 0.0; 
                IsHealthy = true; 
            }

            
            public void DisplayInfo()
            {
                string healthStatus = IsHealthy ? "здоров" : "нездоров";
                Console.WriteLine($"Информация о питомце:");
                Console.WriteLine($"- Кличка: {Name}");
                Console.WriteLine($"- Вид животного: {Species}");
                Console.WriteLine($"- Возраст: {Age} лет");
                Console.WriteLine($"- Вес: {Weight} кг");
                Console.WriteLine($"- Состояние здоровья: {healthStatus}");
            }

         
            public void UpdateWeight(double newWeight)
            {
                if (newWeight > 0)
                {
                    Weight = newWeight;
                    Console.WriteLine($"Вес питомца {Name} изменен на {Weight} кг.");
                }
                else
                {
                    Console.WriteLine("Ошибка: вес должен быть положительным числом.");
                }
            }

            public void UpdateHealthStatus(bool isHealthy)
            {
                IsHealthy = isHealthy;
                string healthStatus = IsHealthy ? "здоров" : "нездоров";
                Console.WriteLine($"Состояние здоровья питомца {Name} изменено на: {healthStatus}");
            }
        }

     
        


        
    }
}




    


    
    
    



