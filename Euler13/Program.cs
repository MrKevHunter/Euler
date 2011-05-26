using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Swensen;

namespace Euler13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readAllLines = File.ReadAllLines("numbers.txt");
            BigInt total = readAllLines.Aggregate<string, BigInt>(0, (current, readAllLine) => current + (BigInt) readAllLine);
            Console.WriteLine(total);
            Console.WriteLine("\n\n\n");
            Console.WriteLine(total.ToString().Substring(0,10));
            Console.ReadLine();
        }
    }
}
