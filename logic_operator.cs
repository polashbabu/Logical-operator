using System;

namespace Logical_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your second number ");
            int number2 = int.Parse(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine("First number is grather then second number ");

            }
            else if (number1==number2)
            {
                Console.WriteLine("first and second number is same ");
            }

            else
            {
                Console.WriteLine("first number is less then second number ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
