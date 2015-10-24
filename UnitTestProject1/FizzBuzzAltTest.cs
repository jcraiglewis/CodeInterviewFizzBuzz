using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTestProject
{
    [TestClass]
    public class FizzBuzzAltTest
    {
        [TestMethod]
        public void TestAllDivisibleAlt()
        {
            FizzBuzzProject.FizzBuzzAlt fb = new FizzBuzzProject.FizzBuzzAlt(9, 15);
            string result = "";
            foreach (string str in fb)
            {
                result += str + " ";
            }

            Assert.AreEqual<string>(result, "Fizz Buzz 11 Fizz 13 14 FizzBuzz ");

        }

        [TestMethod]
        // Tests a series that includes numbers that are not divisible by either 3 or 5
        public void TestNoneDivisibleAlt()
        {
            string result = "";
            FizzBuzzProject.FizzBuzzAlt fb = new FizzBuzzProject.FizzBuzzAlt(16, 17);
            foreach (string str in fb)
            {
                result += str + " ";
            }

            Assert.AreEqual(result, "16 17 ");
        }

        [TestMethod]
        // Test Invalid bounds
        [ExpectedException(typeof(Exception), "Range error: Lower bound must be less than or equal to upper bound.")]
        public void TestRangeExceptionAlt()
        {
            string result = "";
            FizzBuzzProject.FizzBuzzAlt fb = new FizzBuzzProject.FizzBuzzAlt(40, 2);

            foreach (string str in fb)
            {
                result += str + " ";
            }
        }

        [TestMethod]
        // Tests an Index that should be Divisible by 3
        public void TestIndexDivByThreeAlt()
        {
            string result = "";
            FizzBuzzProject.FizzBuzzAlt fb = new FizzBuzzProject.FizzBuzzAlt(0, 200);
            result = fb[99];

            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        // Tests an Index that should be Divisible by 5
        public void TestIndexDivByFiveAlt()
        {
            string result = "";
            FizzBuzzProject.FizzBuzzAlt fb = new FizzBuzzProject.FizzBuzzAlt(0, 200);
            result = fb[125];

            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        // Tests an Index that should be Divisible by 3 and 5
        public void TestIndexDivByThreeAndFiveAlt()
        {
            string result = "";
            FizzBuzzProject.FizzBuzzAlt fb = new FizzBuzzProject.FizzBuzzAlt(0, 200);
            result = fb[60];

            Assert.AreEqual(result, "FizzBuzz");
        }

        [TestMethod]
        // Tests an Index that should be Divisible by neither 3 or 5
        public void TestIndexNotDivByThreeOrFiveAlt()
        {
            string result = "";
            FizzBuzzProject.FizzBuzzAlt fb = new FizzBuzzProject.FizzBuzzAlt(0, 200);
            result = fb[23];

            Assert.AreEqual(result, "23");
        }

        [TestMethod]
        // Test Invalid Indexer
        [ExpectedException(typeof(System.InvalidOperationException), "")]
        public void TestIndexerExceptionAlt()
        {
            string result = "";
            FizzBuzzProject.FizzBuzzAlt fb = new FizzBuzzProject.FizzBuzzAlt(0, 200);

            result = fb[201];
        }

    }
}
