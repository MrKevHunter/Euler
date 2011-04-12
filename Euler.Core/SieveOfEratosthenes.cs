using System;
using System.Collections.Generic;

namespace Euler.Core
{
    public class SieveOfEratosthenes
    {
        private readonly bool[] primes;

        public SieveOfEratosthenes(long limit)
        {
            primes = new bool[limit + 1];
            for (long l = 2; l < primes.LongLength; ++l)
            {
                primes[l] = true;
            }

            for (int i = 2;
                 i != -1;
                 i = Array.FindIndex(primes, i + 1,
                                     b => b))
            {
                for (int j = i*2; j < primes.Length; j += i)
                    primes[j] = false;
            }
        }

        public IEnumerable<long> Primes()
        {
            for (long i = 2; i < primes.LongLength; ++i)
                if (primes[i])
                    yield return i;
        }

        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the very end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}