using System;

namespace FizzBuzzProject
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzAlt fba = new FizzBuzzAlt(0, 200);
            string result = "";
            foreach (string res in fba)
            {
                result += res + " ";

            }
            Console.WriteLine(result);
            Console.WriteLine(fba[55]);
            Console.ReadLine();
            
        }
    }
}
