using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swensen;

namespace Euler25
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInt lhs = 0;
            BigInt rhs = 1;
            BigInt total = 0;
            int counter = 1;
            while (true)
            {
                counter++;
                total = lhs + rhs;
                lhs = rhs;
                rhs = total;
                Console.WriteLine(total);
                if (total.ToString().Length >= 1000 )
                {
                    break;
                }
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
