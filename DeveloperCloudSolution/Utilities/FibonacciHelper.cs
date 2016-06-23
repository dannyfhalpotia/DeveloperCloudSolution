
using System;

namespace DeveloperCloudSolution.Utilities
{
    public static class FibonacciHelper
    {
        private static bool IsPerfectSquare(int a)
        {
            int x = (int)Math.Sqrt(a);
            return Math.Pow(x, x) == a;
        }

        /// <summary>
        /// Returns whether a given number is in the Fibonacci sequence or not.
        /// </summary>
        /// <param name="number">The number to be tested</param>
        /// <returns>True/False depending on result of fibonacci test </returns>
        public static bool IsFibonacciNumber(long number)
        {
            double rootOf5 = Math.Sqrt(5);
            double phi = (1 + rootOf5) / 2;

            long index = (long)Math.Floor(Math.Log(number * rootOf5) / Math.Log(phi) + 0.5);
            long u = (long)Math.Floor(Math.Pow(phi, index) / rootOf5 + 0.5);

            return (u == number);
        }
    }
}