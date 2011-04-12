using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euler.Core;

namespace Euler7
{
    class Program
    {
        static void Main(string[] args)
        {
            long elementAt = new SieveOfEratosthenes(500000).Primes().ElementAt(10000);
            Console.WriteLine(elementAt);
            Console.ReadLine();

        }
    }
}
