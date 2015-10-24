using System;
using System.Collections;


// Alternative implemnetation by implementing an IEnumerator.  The FizzBuzzAlt class is an Enumerable class that sets
// up the Enumerator FBIterator by constructing it with a range and an evaluation function for the number in the range.
namespace FizzBuzzProject
{
    public class FizzBuzzAlt : IEnumerable
    {
        // Constants for outputs and devisors
        const string Condition1 = "Fizz";
        const string Condition2 = "Buzz";
        const string BothCondition = "FizzBuzz";
        const int divisor1 = 3;
        const int divisor2 = 5;

        // Properties to store the bounds
        long _lowerBound;
        long _upperBound;


        /// <summary>
        /// Constructor that takes the upper and lower bounds of the collection
        /// </summary>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <exception>Will throw an exception if the lower bounds is greater than the upper </exception>
        public FizzBuzzAlt(long lower, long upper)
        {
            if (lower > upper)
                throw (new Exception("Range error: Lower bound must be less than or equal to upper bound."));
            _lowerBound = lower;
            _upperBound = upper;
        }


  
        /// <summary>
        /// Evaluation method that must return a string, and take a long as a parameter.  This
        /// Evaluation method is passed to the Iterator and will be used to determine the output based on the 
        /// current number in the range.        
        /// </summary>
        /// <param name="number">Number in the range to be evaluated</param>
        /// <returns>String result of FizzBuzz</returns>
        public string FizzBuzzEval(long number)
        {
            if ((number % divisor1 == 0) && (number % divisor2 == 0))
                return BothCondition;
            else if (number % divisor1 == 0)
                return Condition1;
            else if (number % divisor2 == 0)
                return Condition2;
            else
                return number.ToString();
        }
    
        /// <summary>
        ///  Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An System.Collections.IEnumerator object that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator GetEnumerator()
        {
            return new FBEnumerator(_lowerBound, _upperBound, FizzBuzzEval);
        }

        /// <summary>
        /// Indexer for FizzBuzzAlt - ReadOnly
        /// </summary>
        /// <param name="index">
        /// Given an Index that falls within the range. 
        /// </param>
        /// <returns>
        /// Returns a string with the result of the Evaluation method
        /// </returns>
        /// <exception>
        /// System.InvalidOperationException:
        ///     The index is positioned before the first element of the series or
        ///     after the last element.        
        /// </exception>
        public string this[long index] {
            get
            {
                if (index < _lowerBound || index > _upperBound)
                    throw new System.InvalidOperationException();

                 return FizzBuzzEval(index);
                
            }

         }


    }
}
