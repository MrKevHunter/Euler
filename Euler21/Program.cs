using System;
using System.Linq;
using Euler.Core.Extensions;

namespace Euler21
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i < 10000 && IsAmicableNumber(i); i++)
            {
                total += i;
            }
            Console.WriteLine("The total is: {0}", total);
            Console.ReadLine();
        }

        private static bool IsAmicableNumber(int i)
        {
            int lhs = i.GetProperDivisors().Sum();
            int rhs = lhs.GetProperDivisors().Sum();
            if (i == rhs && i != lhs)
            {
                return true;
            }
            return false;
        }
    }
}