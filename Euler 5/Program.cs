using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            for (int i = 20; ;i++)
            {
                for (int j = 2; j <= 20; j++)
                {
                    if (i%j!=0)
                    {
                        break;
                    }
                    if (j != 20) continue;
                    found = true;
                    Console.WriteLine(i);
                    break;
                }
                if (found)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
