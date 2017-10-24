using System;
using System.Collections.Generic;

namespace The_Even_Fibonacci_Sum_Calculator
{
    public class FibonacciList
    {
        public List<int> fibonacciSeriesForN = new List<int>();

        public FibonacciList(int n)
        {
            for (int i = 0; i < n; i++)
            {
                fibonacciSeriesForN.Add(fillTheSeries(i));
            }
        }

        private int fillTheSeries(int n){
            if (n == 0 || n == 1) 
                return n;
            else
                return fillTheSeries(n - 1) + fillTheSeries(n - 2);
        }
    }
}
