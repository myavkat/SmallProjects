using System;
using System.Collections.Generic;

namespace PE6SumSquareDifference
{
    class Program
    {
        //The sum of the squares of the first ten natural numbers is, 385
        //The square of the sum of the first ten natural numbers is, 3025
        //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is . 2640
        //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        static void Main(string[] args)
        {
            int result;
            result = SquareOfSum(1, 100) - SumOfSquares(1, 100);
            Console.WriteLine(result);
        }

        static int SumOfSquares(int from, int to)
        {
            int sum = 0;
            for (int number = from; number <= to; number++)
            {
                sum += (int)Math.Pow(number, 2);
            }
            return sum;
        }

        static int SquareOfSum(int from, int to)
        {
            int sum = 0;
            for (int number = from; number <= to; number++)
            {
                sum += number;
            }
            return (int)Math.Pow(sum, 2);
        }
    }
}
