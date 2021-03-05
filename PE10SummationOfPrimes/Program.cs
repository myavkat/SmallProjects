using System;
using System.Collections.Generic;

namespace PE10SummationOfPrimes
{
    class Program
    {
        //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        //Find the sum of all the primes below two million.
        static void Main(string[] args)
        {
            long sum=0;
            foreach (var primeNumber in findPrimeNumbers(2,2000000))
            {
                sum += primeNumber;
            }
            Console.WriteLine(sum);
        }
        static List<long> findPrimeNumbers(long from, long to)
        {
            bool toAdd;
            List<long> primeNumbers = new List<long>();
            primeNumbers.Add(2);
            for (long number = from; number <= to; number++)
            {
                toAdd = true;
                foreach (long primeNumber in primeNumbers)
                {
                    if (number/primeNumber == number/(double)primeNumber)
                    {
                        toAdd = false;
                        break;
                    }
                }
                if (toAdd)
                {
                    primeNumbers.Add(number);
                }
            }
            return primeNumbers;
        }
    }
}
