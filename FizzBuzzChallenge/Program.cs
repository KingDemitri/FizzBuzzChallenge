using System.IO;
using System;
using System.Runtime.InteropServices;

namespace LINQ
{
    public class FizzBuzzChallenge
    {

        public static string FizzBuzz(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "fizzbuzz";
            }
            else if (num % 3 == 0)
            {
                return "fizz";
            }
            else if (num % 5 == 0)
            {
                return "buzz";
            }
            else return "";

        }
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(3)); 
            Console.WriteLine(FizzBuzz(5)); 
            Console.WriteLine(FizzBuzz(15)); 
            Console.WriteLine(FizzBuzz(1));  
        }
    }
}