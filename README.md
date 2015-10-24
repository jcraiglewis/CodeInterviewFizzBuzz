# CodeInterviewFizzBuzz
Enumerable FizzBuzz Coding interview

This Project is to use IEnumerable to implement a FizzBuzz series. The objective is to provide a way to use the following algorithm
on potentially large sets of numbers:
Given a range of integers, the program should return "Fizz" for every integer divisible by 3, "Buzz" for every integer divisible
by 5, "FizzBuzz" for every integer by both 3 and 5, and just the integer if it is divisible by neither.

This project implements the IEnumerable interface in two ways:
1. FizzBuzz - Using yield returns that returns an IEnumerable<string>.  This is a simple way to do an enumerator, and is straightfoward
   for using a foreach to print out the range of values returned by the FizzBuzz algorithm.
2. FizzBuzzAlt - This project implements the IEnumerable and an IEnumerator interfaces to get provide a bit more extensibility.  The IEnumerator
   implementation takes an evaluation method in the constructor, and uses it to determine the string to return for each integer in 
   a range. The FizzBuzz logic is in the evaluation method.  Right now, the evaluation method is implemeneted in the IEnumerable class
   FizzBuzzAlt, but could even be provided by the user of the classes.  
   
   The FizzBuzzAlt IEnumerable implementation also implements an Indexer for providing direct results for any index in the given range.

The project includes unit tests for the two implementations.   
