using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler9
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            foreach (var i in Enumerable.Range(1,1000))
            {
                foreach (var j in Enumerable.Range(1,1000))
                {
                    var total = 1000 - i - j;
                    if (i * i + j * j == total * total)
                    {
                        result = i * j * total;
                    }
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
