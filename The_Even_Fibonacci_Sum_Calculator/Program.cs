using System;

namespace The_Even_Fibonacci_Sum_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var readN = Console.ReadLine();
            FibonacciList fibonacciSeries = new FibonacciList(int.Parse(readN));
            var summation = 0;
            foreach (int item in fibonacciSeries.fibonacciSeriesForN)
            {
                if(item != 0 || item != 1)
                {
                    if (item % 2 == 0)
                        summation += item;
                }
            }
            Console.WriteLine("The Even Fibonacci Sum for " + readN + " is "+ summation);
            Console.WriteLine("Press enter or any key to exit this program");
            Console.ReadLine();
        }
    }
}
