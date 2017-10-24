using System;

namespace The_Even_Fibonacci_Sum_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the number N from the console 
            var readN = Console.ReadLine();

            // Initiate FibonacciList object to fetch the fibonacci series for N
            FibonacciList fibonacciSeries = new FibonacciList(int.Parse(readN));
            var summation = 0;

            // Traverse the fibonacci series to sum up only the even numbers
            foreach (int item in fibonacciSeries.fibonacciSeriesForN)
            {
                if(item != 0 || item != 1)
                {
                    if (item % 2 == 0)
                        summation += item;
                }
            }

            // Printout the result in the console
            Console.WriteLine("The Even Fibonacci Sum for " + readN + " is "+ summation);
            Console.WriteLine("Press enter or any key to exit this program");
            Console.ReadLine();
        }
    }
}
