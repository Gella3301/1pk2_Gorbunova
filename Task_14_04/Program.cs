namespace Task_14_04
{ /*Определите класс User, который будет иметь статическое свойство CurrentUser, представляющее текущего пользователя, и метод для его установки.*/
    internal class Program
    {
        public class User
        {
            public int Id;
            public string Name;

           
            public static User CurrentUser;

            public User(int id, string name)
            {
                Id = id;
                Name = name;
            }
            public static void SetCurrentUser(User user)
            {
                CurrentUser = user;
            }

        
            public void DisplayInfo()
            {
                Console.WriteLine($"ID: {Id}, Имя: {Name}");
            }
        }

            static void Main(string[] args)
            {
              
                User user1 = new User(11037, "Эми");
                

             
                User.SetCurrentUser(user1);

                Console.WriteLine("Текущий пользователь:");
                User.CurrentUser.DisplayInfo();

              
            }
        
    }
}
