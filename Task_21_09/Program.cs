namespace Task_21_09
{ /*создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
• поиск билета с максимальной суммой,
• билета с минимальной суммой,
• выведите список билетов с багажом
• выведите список люготных билетов*/
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var tic = new List<Ticket>();

            for (int i = 0; i < 30; i++)
                tic.Add(new Ticket
                {
                    Price = rnd.Next(1000, 10001),
                    HasLuggage = rnd.Next(2) == 0,
                    IsDiscount = rnd.Next(4) == 0
                });

           
            Console.WriteLine($"Mаксимальная цена: {tic.Max(x => x.Price)} Mинимальная цена: {tic.Min(x => x.Price)}");

            Console.WriteLine("\nСписок билетов с  багажом:");
            tic.FindAll(x => x.HasLuggage).ForEach(x => Console.WriteLine(x.Price));

            Console.WriteLine("\nЛьготные билеты:");
            tic.FindAll(x => x.IsDiscount).ForEach(x => Console.WriteLine(x.Price));
        }
    }
    
}
