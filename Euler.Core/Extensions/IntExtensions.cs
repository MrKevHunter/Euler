// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IntExtensions.cs" company="">
//   
// </copyright>
// <summary>
//   The divisor number type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler.Core.Extensions
{
    /// <summary>
    /// The divisor number type.
    /// </summary>
    public enum DivisorNumberType
    {
        /// <summary>
        /// The deficient.
        /// </summary>
        Deficient,

        /// <summary>
        /// The abundent.
        /// </summary>
        Abundent,

        /// <summary>
        /// The perfect.
        /// </summary>
        Perfect
    }

    /// <summary>
    /// The int extensions.
    /// </summary>
    public static class IntExtensions
    {
        public static bool IsPrime(this int value)
        {
            return SieveOfEratosthenes.IsPrime(value);
        }


        public static IEnumerable<int> GetProperDivisors(this int input)
        {
            yield return 1;
            for (int i = 2; i <= input / 2; i++)
            {
                if (input % i == 0)
                {
                    yield return i;
                }
            }
        }

        public static IEnumerable<int> GetProperDivisors2(this int input)
        {
            var max = (int) Math.Sqrt(input);
            yield return 1;
            for (int i = 2; i <= max; ++i)
            {
                if (input%i == 0)
                {
                    yield return i;
                    if (i != max)
                    {
                        yield return input/i;
                    }
                }
            }
        }

        /// <summary>
        /// The get divisor number type.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        /// <returns>
        /// </returns>
        public static DivisorNumberType GetDivisorNumberType(this int input)
        {
            int result = input.GetProperDivisors().Sum();

            if (result == input)
            {
                return DivisorNumberType.Perfect;
            }

            if (result < input)
            {
                return DivisorNumberType.Deficient;
            }

            return DivisorNumberType.Abundent;
        }
    }
}