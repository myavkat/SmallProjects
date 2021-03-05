using System;
using System.Collections.Generic;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The prime factors of 13195 are 5, 7, 13 and 29.
            What is the largest prime factor of the number 600851475143 ?*/

            foreach (long primeFactors in primeFactorization(600851475143))
            {
                Console.WriteLine(primeFactors); ;
            }
            
        }

        static List<long> primeFactorization(long input)
        {
            List<long> primeFactorsOfInput=new List<long>();
            List<long> primeNumbers = findPrimeNumbers((long)Math.Sqrt(input));

            foreach (long primeNumber in primeNumbers)
            {
                if (input/primeNumber==input/(double)primeNumber)
                {
                    primeFactorsOfInput.Add(primeNumber);
                }
            }

            return primeFactorsOfInput;
        }


        static List<long> findPrimeNumbers(long input)
        {
            bool add=false;
            List<long> primeNumbers = new List<long>();
            primeNumbers.Add(2);

            for (long i = 3; i < input; i+=2)
            {
                add = true;
                foreach (long primeNumber in primeNumbers)
                {
                    if (i/primeNumber==i/(double)primeNumber)
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    primeNumbers.Add(i);
                    add = false;
                }
            }
            return primeNumbers;
        }
    }
}
