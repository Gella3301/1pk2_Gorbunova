namespace Task_02_04
{
    using System;

    class Program
    {
        static void Main(string[] args)
        { /* Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату) произведите
расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
этом
*/

            Console.Write("Введите год рождения: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц рождения: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите день рождения: ");
            int day = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(year, month, day);

            DateTime currentDate = DateTime.Today;

            
            int age = currentDate.Year - birthDate.Year;

          
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }

           
            if (age >= 18)
            {
                Console.WriteLine("Вы  совершеннолетний.");
            }
            else
            {
                Console.WriteLine("Вы несовершеннолетний.");
            }
        }
    }
}
