using System;
using System.Linq;
using Euler.Core;

namespace Euler3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const double targetNumber = 600851475143;
            var sieveOfEratosthenes = new SieveOfEratosthenes((long) Math.Sqrt(targetNumber));
            foreach (long l in sieveOfEratosthenes.Primes().Reverse().Where(l => targetNumber%l == 0))
            {
                Console.WriteLine(l);
                break;
            }
            Console.ReadLine();
        }
    }
}