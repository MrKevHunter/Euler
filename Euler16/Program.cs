// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Linq;
using Swensen;

namespace Euler16
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
            BigInt bigInt = BigInt.Pow(2, 1000);
            int result = bigInt.ToString().Sum(l => Int32.Parse(l.ToString()));
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}