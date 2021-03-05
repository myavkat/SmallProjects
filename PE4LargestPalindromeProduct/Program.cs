using System;
using System.Collections.Generic;

namespace PE4LargestPalindromeProduct
{
    class Program
    {
        //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.

        static void Main(string[] args)
        {
            List<int> palindromeProducts = new List<int>();
            List<int> productsToRemove = new List<int>();
            foreach (var product in ProductOfNumbers(100, 999))
            {
                if (IsPalindrome(product))
                {
                    palindromeProducts.Add(product);
                }
            }
            foreach (var palindromeProduct in palindromeProducts)
            {
                foreach (var palindromeProduct2 in palindromeProducts)
                {
                    if (palindromeProduct!=palindromeProduct2)
                    {
                        productsToRemove.Add(Math.Min(palindromeProduct, palindromeProduct2));
                    }
                }
            }
            foreach (var productToRemove in productsToRemove)
            {
                palindromeProducts.Remove(productToRemove);
            }
            foreach (var result in palindromeProducts)
            {
                Console.WriteLine(result);
            }
            
        }
        public static bool IsPalindrome(int number)
        {
            char[] numberCharArray = number.ToString().ToCharArray();
            for (int index = 0; index < numberCharArray.Length; index++)
            {
                if (numberCharArray[index] != numberCharArray[numberCharArray.Length - 1 - index])
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> ProductOfNumbers(int minValue ,int maxValue)
        {
            List<int> Products = new List<int>();
            for (int minOne = minValue; minOne <= maxValue; minOne++)
            {
                for (int minTwo = minValue; minTwo <= maxValue; minTwo++)
                {
                    Products.Add(minOne*minTwo);
                }
            }
            return Products;
        }
    }
}
