// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using Euler.Core.Extensions;

namespace Euler23
{
    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        private static void Main()
        {

    
            int[] abundantNumbers = GetAllAbundantNumbers().ToArray();

            int total = GetSumOfIntegersWhichAreNotTheSumOfTwoAbundantNumbers(abundantNumbers).Sum();

            Console.WriteLine("Total is " + total);
            Console.ReadLine();
        }

        private static IEnumerable<int> GetSumOfIntegersWhichAreNotTheSumOfTwoAbundantNumbers(int[] abundantNumbers)
        {
            for (int i = 1; i <= 28123; i++)
            {
                if (i%1000 == 0)
                {
                    Console.WriteLine("Processing Number " + i);
                }

                bool isSumOfTwoAbundantNumbers = IsSumOfTwoAbundantNumbers(abundantNumbers, i);
                if (!isSumOfTwoAbundantNumbers)
                {
                    yield return i;
                }
            }

        }

 
        private static bool IsSumOfTwoAbundantNumbers(int[] abundantNumbers, int target)
        {
            for (int lhs = 0; lhs < abundantNumbers.Length; lhs++)
            {
                if (lhs>target)
                {
                    return false;
                }
                for (int rhs = lhs; rhs < abundantNumbers.Length; rhs++)
                {
                    int total = abundantNumbers[lhs] + abundantNumbers[rhs];
                    if (total == target)
                    {
                        return true;
                    }

                    if (total > target)
                    {
                        break;
                    }
                }
            }

            return false;
        }


        /// <summary>
        /// The get all abundant numbers.
        /// </summary>
        /// <returns>
        /// </returns>
        private static IEnumerable<int> GetAllAbundantNumbers()
        {
            for (int i = 12; i <= 28123; i+=1)
            {
                DivisorNumberType divisorNumberType = i.GetDivisorNumberType();
                if (divisorNumberType == DivisorNumberType.Abundent)
                {
                    yield return i;
                }
            }
        }
    }
}