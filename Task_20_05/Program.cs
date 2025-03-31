namespace Task_20_05
{ /*Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
• Guest (только чтение)
• User (чтение + комментарии)
• Moderator (удаление контента)
• Admin (полный доступ)
Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалитьпост).На основе уровня доступа выводите сообщение (например,
"Ошибка: Недостаточно прав!")*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Access[] users =
            {
                Access.Guest,
                Access.User,
                Access.Moderator,
                Access.Admin
            };
            foreach (var user in users)
            {
                Console.WriteLine($"Проверка прав для: {user}");

                Console.Write("Может читать? ");
                Console.WriteLine(CanRead(user) ? "Да" : "Нет");

                Console.Write("Может комментировать? ");
                Console.WriteLine(CanComment(user) ? "Да" : "Нет");

                Console.Write("Может удалять пост? ");
                Console.WriteLine(CanDeletePost(user) ? "Да" : "Нет");

                Console.WriteLine();
            }
            static bool CanRead(Access userLevel) => userLevel >= Access.Guest;
            static bool CanComment(Access userLevel) => userLevel >= Access.User;
            static bool CanDeletePost(Access userLevel) => userLevel >= Access.Moderator;
        }
    }
            
    
}
