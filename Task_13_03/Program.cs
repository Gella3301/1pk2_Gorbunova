﻿namespace Task_13_03
{ /*создайте класс автомобиля
свойства:
номер авто, марка, цвет, текущая скорость
методы:
езда (симитировать равномерное ускорение скорости автомобиля)
торможение (при превышении скорости автомобиля свыше допустимой - он должен остановиться)
конструторы
предусмотрите разные варианты инициализации объектов*/
    public class Car
    {
        #region
        public string LicensePlate; 
        public string Brand;
        public string Color;
        public int CurrentSpeed;
        private const int MaxSpeed = 120;
        #endregion
        public Car()
        {
            LicensePlate = "Unknown";
            Brand = "Unknown";
            Color = "Unknown";
            CurrentSpeed = 0; 
        }

        public Car(string licensePlate, string brand, string color, int currentSpeed)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = color;
            CurrentSpeed = currentSpeed;
        }

   
        public Car(string licensePlate, string brand)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = "Unknown"; 
            CurrentSpeed = 0; 
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"Информация об автомобиле:");
            Console.WriteLine($"- Номер авто: {LicensePlate}");
            Console.WriteLine($"- Марка: {Brand}");
            Console.WriteLine($"- Цвет: {Color}");
            Console.WriteLine($"- Текущая скорость: {CurrentSpeed} км/ч");
        }

 
        public void Drive(int acceleration)
        {
            if (acceleration > 0)
            {
                CurrentSpeed += acceleration;
                Console.WriteLine($"Автомобиль {LicensePlate} ускорился до {CurrentSpeed} км/ч.");
            }
            else
            {
                Console.WriteLine("Ошибка: ускорение должно быть положительным числом.");
            }

            
            if (CurrentSpeed > MaxSpeed)
            {
                Console.WriteLine($"Превышена максимальная скорость! Автомобиль {LicensePlate} остановлен.");
                Brake();
            }
        }

      
        public void Brake()
        {
            CurrentSpeed = 0;
            Console.WriteLine($"Автомобиль {LicensePlate} остановлен.");
        }
    }

  
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Car car1 = new Car(); 
            Car car2 = new Car("A123BC", "Toyota", "Red", 60);
            Car car3 = new Car("B456DE", "BMW"); 

            
            Console.WriteLine("Информация об автомобилях:");
            car1.DisplayInfo();
            Console.WriteLine();
            car2.DisplayInfo();
            Console.WriteLine();
            car3.DisplayInfo();
            Console.WriteLine();

            
            car2.Drive(30); 
            car2.Drive(50); 
            car2.Drive(20); 
            car2.Brake(); 
        }
    }

}
