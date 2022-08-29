﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public static void Fibonacci()
        {
            int num1 = 0;
            int num2 = 1;
            int num3, i, number;

            Console.WriteLine("Enter Number :- ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + " " + num2 + " ");

            for (i = 2; i < number; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
