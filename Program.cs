/* Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, 
 введенные из командной строки, и выводящую результат выполнения на экран.*/


namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                int sum = 0;
                int num1 = Convert.ToInt32(args[0]);
                string symbol = args[1];
                int num2 = Convert.ToInt32(args[2]);

                if (symbol == "+") 
                {
                    sum = num1 + num2;  
                }
                if (symbol == "-")
                {
                    sum = num1 - num2;
                }
                if (symbol == "*")
                {
                    sum = num1 * num2;
                }
                if (symbol == "/")
                {
                    sum = num1 / num2;
                }
                Console.WriteLine(sum);
            }
                
        }
    }
}