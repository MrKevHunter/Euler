// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IntExtensions.cs" company="">
//   
// </copyright>
// <summary>
//   The divisor number type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


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
        /// <summary>
        /// The get divisors.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        /// <returns>
        /// </returns>
        public static IEnumerable<int> GetDivisors(this int input)
        {
            yield return 1;
            for (int i = 2; i <= input/2; i++)
            {
                if (input%i == 0)
                {
                    yield return i;
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
            int result = input.GetDivisors().Sum();

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