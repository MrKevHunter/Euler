using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Euler_4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();
            IEnumerable<int> palindromes = GetPalindromes(998001);

            Console.WriteLine("{0} palindromes found", palindromes.Count());
            foreach (int palindrome in palindromes)
            {
                for (int i = 999 - 1; i >= 0; i--)
                {
                    for (int j = 999 - 1; j >= 0; j--)
                    {
                        int result = i*j;
                        if (result < palindrome)
                        {
                            break;
                        }
                        if (result == palindrome)
                        {
                            Console.WriteLine("{0} * {1} = {2}", i, j, palindrome);
                            s.Stop();
                            Console.WriteLine("Found in {0} milliseconds", s.ElapsedMilliseconds);
                            Console.ReadLine();
                            return;
                            break;
                        }
                    }
                }
            }
        }

        private static IEnumerable<int> GetPalindromes(int max)
        {
            for (int i = max; i >= 0; i--)
            {
                if (i.ToString() == new string(i.ToString().Reverse().ToArray()))
                {
                    yield return i;
                }
            }
        }
    }
}