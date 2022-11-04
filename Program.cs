using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 0;
            int secondValue = 1;

            Console.Write("How many values of the Fibonacci sequence would you like to compute?: ");
            // int.Parse(...) parsing string (user input) to int
            int n = int.Parse(Console.ReadLine());

            // Empty space
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(firstValue);

                int temporarySlot = secondValue;
                secondValue = firstValue + secondValue;
                firstValue = temporarySlot;

            }
        }
    }
}
