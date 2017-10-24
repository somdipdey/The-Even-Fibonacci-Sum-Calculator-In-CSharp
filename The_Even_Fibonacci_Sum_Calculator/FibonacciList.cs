using System;
using System.Collections.Generic;

namespace The_Even_Fibonacci_Sum_Calculator
{
    public class FibonacciList
    {
        // Initiate a list to hold the fibonacci series of number N
        public List<int> fibonacciSeriesForN = new List<int>();

        // Constructor which accepts integer n (number N)
        public FibonacciList(int n)
        {
            for (int i = 0; i < n; i++)
            {
                // Adds the fibonacci number to the list
                fibonacciSeriesForN.Add(fillTheSeries(i));
            }
        }

        // Recursive function to generate fibonacci number
        private int fillTheSeries(int n){
            if (n == 0 || n == 1) 
                return n;
            else
                return fillTheSeries(n - 1) + fillTheSeries(n - 2);
        }
    }
}
