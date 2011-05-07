using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CreditCardNumberGenerator;

namespace CreditCardGen
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = @"C:\Users\Images\Folder1\Folder2\";

            
            Console.WriteLine(s);
            Console.ReadLine();

            IEnumerable<string> enumerable = RandomCreditCardNumberGenerator.GenerateMasterCardNumbers(1)
                .Distinct().
                Where(x => RandomCreditCardNumberGenerator.IsValidCreditCardNumber(x)).
                Take(100);

            foreach (var x in enumerable)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
