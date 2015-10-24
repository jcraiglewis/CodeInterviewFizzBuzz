using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTestProject
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        // Tests a series that includes numbers divisible by 3, 5, and both
        public void TestAllDivisible()
        {

            string result = "";
            foreach (string str in FizzBuzzProject.FizzBuzz.FizzBuzzIt(9, 15))
            {
                result += str + " ";
            }
            
            Assert.AreEqual(result, "Fizz Buzz 11 Fizz 13 14 FizzBuzz ");
        }

        [TestMethod]
        // Tests a series that includes numbers that are not divisible by either 3 or 5
        public void TestNoneDivisible()
        {
              string result = "";
            foreach (string str in FizzBuzzProject.FizzBuzz.FizzBuzzIt(16, 17))
            {
                result += str + " ";
            }

            Assert.AreEqual(result, "16 17 ");
        }

        [TestMethod]
        // Test Invalid bounds
        [ExpectedException(typeof(Exception), "Range error: Lower bound must be less than or equal to upper bound.")]
        public void TestRangeException()
        {
            string result = "";
            foreach (string str in FizzBuzzProject.FizzBuzz.FizzBuzzIt(40,2))
            {
                result += str + " ";
            }
        }
    }
}
