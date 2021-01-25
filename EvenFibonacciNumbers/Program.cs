﻿using System;
using System.Collections.Generic;

namespace EvenFibonacciNumbers
{
    class Program
    {
        /*Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
          1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
          By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.*/
        static void Main(string[] args)
        {
            int a = 1;
            int b;
            int c = 0;
            List<int> numbers = new List<int>();
            for (int i = 1; i < 4000000; i=b+i)
            {
                b = a;
                a = i;
                if (i/2 == i/2.0)
                {
                    numbers.Add(i);
                }
            }
            foreach (int number in numbers)
            {
                c = c + number;
            }
            Console.WriteLine(c);
        }
    }
}
