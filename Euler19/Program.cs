using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler19
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.Parse("01 Jan 1901");
            DateTime endDate = DateTime.Parse("31 Dec 2000");
            int total = 0;
            while (startDate <= endDate)
            {
                if (startDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    total++;
                }
                startDate = startDate.AddMonths(1);
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
