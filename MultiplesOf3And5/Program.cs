using System;
using System.Collections.Generic;

namespace MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
              Find the sum of all the multiples of 3 or 5 below 1000.*/
            List<int> basket = new List<int>();
            int a = 0;

            for (int i = 3; i < 1000; i = i + 3)
            { basket.Add(i); }
            
            for (int i = 5; i < 1000; i = i + 5)
            { if (!basket.Contains(i)) { basket.Add(i); } }
            
            foreach (int number in basket)
            { a = a + number; }

            Console.WriteLine(a);
        }
    }
}
