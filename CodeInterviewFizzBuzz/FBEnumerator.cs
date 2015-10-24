using System;
using System.Collections;


namespace FizzBuzzProject
{

    /// <summary>
    /// Enumerator implementation for FizzBuzzAlt
    /// </summary>
    public class FBEnumerator:IEnumerator
    {
        
        private long _index;
        private long _lowerIdx;
        private long _upperIdx;
        private Func<long, string> _evalFunction;

        /// <summary>
        /// Constructor for the Enumerator class
        /// </summary>
        /// <param name="lower">Lower bounds for series</param>
        /// <param name="upper">Upper bounds for series</param>
        /// <param name="evalFunction">Function that takes a long and returns a string to evaluate numbers in series</param>
        /// <exception>Will throw an exception if the lower bounds is greater than the upper </exception>
        public FBEnumerator(long lower, long upper, Func<long, string> evalFunction)
        {
            if (lower > upper)
                throw (new Exception("Range error: Lower bound must be less than or equal to upper bound."));
            _lowerIdx = lower;
            _upperIdx = upper;
            _index = lower-1;
            _evalFunction = evalFunction;
        }

        

        /// <summary>
        /// Gets the current element in the collection.
        /// </summary>
        /// <returns>The current element in the collection.</returns>
        /// <exception>
        /// System.InvalidOperationException:
        ///     The enumerator is positioned before the first element of the collection or
        ///     after the last element.
        ///</exception>
        public object Current
        {
            get
            {
                if (_index < _lowerIdx || _index > _upperIdx)
                    throw new System.InvalidOperationException();
                return _evalFunction(_index);
            }
        }

        /// <summary>
        /// Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns>
        /// true if the enumerator was successfully advanced to the next element; false
        ///     if the enumerator has passed the end of the series.
        /// </returns>
        public bool MoveNext()
        {
            if (_index >= _upperIdx)
                return false;
            else
                _index++;
            return true;
        }


        /// <summary>
        ///  Sets the enumerator to its initial position, which is before the first element
        ///     in the collection.
        /// </summary>
        public void Reset()
        {
            _index = _lowerIdx - 1;
        }

    }
}
