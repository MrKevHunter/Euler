using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euler.Core;

namespace Euler10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new SieveOfEratosthenes(2000000).Primes().Sum(prime => prime));
            Console.ReadLine();
        }
    }
}
