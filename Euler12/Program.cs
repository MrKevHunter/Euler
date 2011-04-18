using System;

namespace Euler12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int maxNumberOfDivisions = 0;
            int i = 0;
            long total = 0;
            while (true)
            {
                i++;
                total += i;
                if (total%2!=0)
                {
                    continue;
                }

                int numberOfDivisors = NumberOfDivisors(total);

                if (numberOfDivisors>maxNumberOfDivisions)
                {
                    maxNumberOfDivisions = numberOfDivisors;
                
                Console.WriteLine("{0} has {1} divisors", total, numberOfDivisors);
                if (numberOfDivisors >= 500)
                {
                    Console.WriteLine("Hello");
                    break;
                }
                    }
            }

            Console.ReadLine();
        }

        private static int NumberOfDivisors(long total)
        {
            int count = 0;
            for (int i = 1; i <= Math.Sqrt(total); i++)
            {
                if (total%i == 0)
                {
                    count++;
                }
            }
            return count*2;
        }
    }
}