using System;

namespace SumTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine($"The sum is: {sum}");

            if (sum % 2 == 0)
            {
                Console.WriteLine("The number is EVEN");
            }
            else
            {
                Console.WriteLine("The number is ODD");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
