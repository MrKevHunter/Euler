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
using System.Diagnostics;
using System.Linq;

namespace Euler14
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
            IEnumerable<int> enumerable = Enumerable.Range(1, 1000000);
            int bestNumber = 0;
            int maximumNumberOfSteps = 0;
            Stopwatch s = new Stopwatch();
            s.Start();
            foreach (var i in enumerable.AsParallel())
            {
                Console.WriteLine("Processing number:{0}",i);
                int numberOfSteps = ProcessNumber(i);

                if (numberOfSteps>maximumNumberOfSteps)
                {
                    maximumNumberOfSteps = numberOfSteps;
                    bestNumber = i;
                }
            }
            s.Stop();
            Console.WriteLine("{0} has {1} steps\nfound in {2} seconds", bestNumber, maximumNumberOfSteps,s.Elapsed.Seconds);

        }

        private static Dictionary<double,int> jumpList = new Dictionary<double, int>();
        /// <summary>
        /// The process number.
        /// </summary>
        /// <param name="number">
        /// The start number.
        /// </param>
        /// <returns>
        /// The process number.
        /// </returns>
        private static int ProcessNumber(double number)
        {
            int length = 1;
            double startNumber = number;
            while (number != 1)
            {
                if (jumpList.ContainsKey(number))
                {
                    length += jumpList[number];
                    break;
                }
                length++;
                if (IsEven(number))
                {
                    number = number/2;
                }
                else
                {
                    number = (number*3) + 1;
                }
            }
            if (!jumpList.ContainsKey(startNumber))
            {
                jumpList.Add(startNumber, length);
            }
            return length;
        }

        /// <summary>
        /// The is even.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        /// <returns>
        /// The is even.
        /// </returns>
        private static bool IsEven(double input)
        {
            return input%2 == 0;
        }
    }
}