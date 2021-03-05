using System;

namespace PE9SpecialPythagoreanTriplet
{
    class Program
    {
        //A Pythagorean triplet is a set of three natural numbers, a < b< c, for which,
        //a^2 + b^2 = c^2
        //For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
        //There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        //Find the product a*b*c.
        static void Main(string[] args)
        {
            for (int c = 999; c >= 0; c--)
            {
                for (int b = c - 1; b >= 0; b--)
                {
                    for (int a = b - 1; a >= 0; a--)
                    {
                        if (a+b+c==1000 && Math.Pow(a,2)+Math.Pow(b,2)==Math.Pow(c,2))
                        {
                            Console.WriteLine(a * b * c);
                        }

                    }
                }
            }
        }
    }
}
