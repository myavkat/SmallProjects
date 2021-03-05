using System;

namespace PE7TenThousandFirstPrime
{
    class Program
    {
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10 001st prime number?

        static void Main(string[] args)
        {
            Console.WriteLine(FindPrime(10001));
            
        }

        static int FindPrime(int rank)
        {
            int innerRank=0;
            bool toAdd;
            for (int number = 2; number <= Int32.MaxValue; number++)
            {
                toAdd = true;
                for (int number2 = 2; number2 < number; number2++)
                {
                    if (number%number2 == 0)
                    {
                        toAdd = false;
                        break;
                    }
                }
                if (toAdd)
                {
                    innerRank++;
                    if (rank == innerRank)
                    {
                        return number;
                    }
                }
            }
            return 0;
        }
    }
}
