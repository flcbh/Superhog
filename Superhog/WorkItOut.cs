using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhog
{
    public static class WorkItOut
    {
        /// <summary>
        /// Return the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        /// <returns></returns>
        public static int GetPalindrome()
        {
            var result = 0;

            // outer will be first loop
            for (int i = 10; i < 1000; i++)
            {
                // go through the numbers from 100 to 1000
                for (int x = 10; x < 1000; x++)
                {
                    // work out the product
                    var y = i * x;

                    //var yb = y.ToString();
                    //var yb = new string(y.ToString().Reverse().ToArray());

                    //To get the correct values I thought it would be better to implement a private method to do the calculation and return the values for testing.
                    //It is not necessary to work with strings in this logic.

                    var yb = Calculate(y);

                    // figure out if this is a palindrome
                    if (y == yb)
                    {
                        if (y > result) result = y;
                    }
                }

            }

            return result;
        }

        /// <summary>
        /// Calculates and returns value for testing.
        /// </summary>
        /// <param name="n">numeric value</param>
        /// <returns>number value</returns>
        private static int Calculate(int n)
        {
            var result = 0;

            while (n > 0)
            {
                result = result * 10 + n % 10;
                n /= 10;
            }

            return result;
        }
    }
}
