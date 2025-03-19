namespace Task_14_03
{ /*Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал. Сделайте так, чтобы метод работал только для неотрицательных чисел. */
   
    
        public class MathOperations
        {
            
            public static int Factorial(int number)
            {
              
            if (number < 0)
                {
                    return 0; 
                }

                if ( number == 1)
                {
                    return 1;
                }

                int result = 1;
                for (int i = 2; i <= number; i++)
                {
                    result *= i;
                }

                return result;
            }
        }

       
        internal class Program
        {
            static void Main(string[] args)
            {
            
            
                Console.WriteLine("Факториал 0: " + MathOperations.Factorial(0)); 
                Console.WriteLine("Факториал -1: " + MathOperations.Factorial(-1)); 
                Console.WriteLine("Факториал 12: " + MathOperations.Factorial(12)); 
                Console.WriteLine("Факториал 7: " + MathOperations.Factorial(7)); 

               
               
            }
        }
    
}

