using System;
using System.Collections.Generic; // need this to use list class

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Timer1 = DateTime.Now; // start timer
            List<int> PrimeList = new List<int>(); //initilize list class
            PrimeList.Add(2); // adds 2 manually
            for (int i = 1; i <= 100000; i+= 2) // increment over odd nums only 
            {
                if (isPrime(i))
                {
                    PrimeList.Add(i); //add numbers to list which is faster than adding ToArrays
                }
            }
            DateTime Timer2 = DateTime.Now; //end timer before printing numbers because the calculation is fast, but displaying the numbers is slow
            PrimeList.ForEach(Console.WriteLine); // prints everything in the list
            Console.WriteLine("Prime numbers count " + PrimeList.Count); // should be 9592
            Console.WriteLine("Time: " + (Timer2 - Timer1)); //should be better than everyone's XD
            Console.WriteLine("I Like Cheese Pizza please :)");
            Console.ReadLine(); 
        }
        static Boolean isPrime(int i)
        {
            int checker = 5;

            if (i == 1) // becuase 1 is not a prime
            {
                return false;
            }
            if (i <= 3) //will print 3 didn't work for 2 need to add that to the array
            {
                return true;
            }
            if ((i % 2) == 0) // no even numbers kind of redundant but yea
            {
                return false;
            }
            if ((i % 3) == 0) // no numbers divisible by 3
            {
                return false;
            }
            while ((checker * checker) <= i) // starts at 5 checks for perfect squares as it loops
            {
                if ((i % checker) == 0)
                {
                    return false;
                }
                if ((i % (checker + 2)) == 0) // add 2 to checker so 5 first then 7, 9, 11 etc...
                {
                    return false;
                }
                checker = checker + 6;// read about multiples of 6 on wikipedia: Primality Test
            }
            return true;
        }
    }
}