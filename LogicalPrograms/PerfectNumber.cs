﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public static void Perfectnumber()
        {
            int i;
            int sum = 0;
            int n;
            Console.WriteLine("Enter any number to check whetner it is Perfect Number or not");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (n == sum)
                Console.WriteLine("It is a Perfect Number");
            else
                Console.WriteLine("It is Not a Perfect Number");
        }
    }
}
