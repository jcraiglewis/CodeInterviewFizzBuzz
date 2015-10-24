using System;
using System.Collections.Generic;

namespace FizzBuzzProject
{
    public class FizzBuzz
    {
        const string Condition1 = "Fizz";
        const string Condition2 = "Buzz";
        const string BothCondition = "FizzBuzz";
        const int divisor1 = 3;
        const int divisor2 = 5;

        /// <summary>
        ///     Given lower and upper bounds,
        ///     Returns an enumerator that iterates through the FizzBuzz collection of results.        
        /// </summary>
        /// <param name="lowerBound">Lower Bound of series</param>
        /// <param name="upperBound">Upper Bound of series</param>
        /// <returns>
        ///     An System.Collections.Generic.IEnumerator that can be used to iterate through
        ///     the FizzBuzz "collection".
        /// </returns>
        /// <exception>
        ///  Throws an exception if the lower bound is greater than the upper bounds
        /// </exception>
        public static System.Collections.Generic.IEnumerable<string> FizzBuzzIt(long lowerBound, long upperBound)
        {
            if (lowerBound > upperBound)
                throw (new Exception("Range error: Lower bound must be less than or equal to upper bound."));

            // Loop through the range, returning: FizzBuzz for numbers divisible by 3 and 5
            // Fizz for numbers divisible by 3
            // Buzz for numbers divisible by 5
            // The number if divisible by neither
            // Use yield returns for the Enumerator
            for (long idx = lowerBound; idx <= upperBound; idx++)
            {
                if ((idx % divisor1 == 0) && (idx % divisor2 == 0))
                    yield return BothCondition;
                else if (idx % divisor1 == 0)
                    yield return Condition1;
                else if (idx % divisor2 == 0)
                    yield return Condition2;
                else
                    yield return idx.ToString();
            }
        }

    }
}
