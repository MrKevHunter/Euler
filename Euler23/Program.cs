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
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            int[] abundantNumbers = GetAllAbundantNumbers().ToArray();

            int total = GetSumOfNonIenumerables(abundantNumbers).Sum();

            Console.WriteLine("Total is " + total);
            Console.ReadLine();
        }

        private static IEnumerable<int> GetSumOfNonIenumerables(int[] abundantNumbers)
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

        /// <summary>
        /// The is sum of two abundant numbers.
        /// </summary>
        /// <param name="abundantNumbers">
        /// The abundant numbers.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <returns>
        /// The is sum of two abundant numbers.
        /// </returns>
        private static bool IsSumOfTwoAbundantNumbers(int[] abundantNumbers, int target)
        {
            for (int j = 0; j < abundantNumbers.Length; j++)
            {
                if (j>target)
                {
                    return false;
                }
                for (int k = j; k < abundantNumbers.Length; k++)
                {
                    int total = abundantNumbers[j] + abundantNumbers[k];
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