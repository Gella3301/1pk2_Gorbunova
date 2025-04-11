namespace Task_24_08
{
    internal class Program
    { /*реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения, введенные пользователем*/
        static void Main(string[] args)
        {
            string filePath = "text.txt";

            Console.WriteLine("Введите текст для поиска:");
            string searchText = Console.ReadLine();
           

            Console.WriteLine("Введите текст для замены:");
            string replaceText = Console.ReadLine();
            

            ReplaceInFile(filePath, searchText, replaceText);

            Console.WriteLine("Замена выполнена успешно.");
            Console.ReadKey();

        }
        static void ReplaceInFile(string filePath, string searchText, string replaceText)
        {

           
            string fileContent = File.ReadAllText(filePath);

            
            fileContent = fileContent.Replace(searchText, replaceText, StringComparison.OrdinalIgnoreCase);

            File.WriteAllText(filePath, fileContent);
        }
    }
}
