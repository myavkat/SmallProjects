using System;

namespace PE5SmallestMultiple
{
    class Program
    {
        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        //What is the smallest  number that is evenly divisible by all of the numbers from 1 to 20?
        static void Main(string[] args)
        {
            for (int number = 20000; number <= 20000000000; number++)
            {
                if (EvenlyDivisible(number,2,20))
                {
                    Console.WriteLine(number);
                }
            }
        }

        static bool EvenlyDivisible(int number, int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                if (number%i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
