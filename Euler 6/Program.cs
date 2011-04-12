using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler6
{
    class Program
    {
        static void Main(string[] args)
        {
            long sumOfSquares = GetSumOfSquares();
            long SquareOfSum = GetSquareOfSum();
            Console.WriteLine(sumOfSquares-SquareOfSum);
            Console.ReadLine();
        }

        private static long GetSquareOfSum()
        {
            long result = 0;
            for (int i = 1; i <= 100; i++)
            {
                result += i*i;
            }
            return result;
        }

        private static long GetSumOfSquares()
        {
            long result = 0;
            for (int i = 1; i <= 100; i++)
            {
                result += i;
            }
            return result*result;
        }
    }
}
