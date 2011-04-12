using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_4
{
    class Program
    {
        static void Main(string[] args)
        {
           IEnumerable<int> palindromes =  GetPalindromes(998001);
      
            Console.WriteLine("{0} palindromes found",palindromes.Count());
            foreach (var palindrome in palindromes)
            {
                for (int i = 999 - 1; i >= 0; i--)
                {
                    for (int j = 999 - 1; j >= 0; j--)
                    {
                        int result = i*j;
                        if (result<palindrome)
                        {
                            break;
                        }
                        if (result == palindrome)
                        {
                            Console.WriteLine("{0} * {1} = {2}",i,j,palindrome);
                            Console.ReadLine();
                            break;
                        }
                    }
                }
            }
            Console.ReadLine();
        }

        private static IEnumerable<int> GetPalindromes(int max)
        {
            for (int i = max; i >= 0; i--)
            {

                if (i.ToString()==new string(i.ToString().Reverse().ToArray()))
                {
                    yield return i;
                }
            }
        }
    }
}
