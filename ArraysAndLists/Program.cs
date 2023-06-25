using System;
using System.Collections.Generic;
using System.Linq;
namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var even = new List<int>();
            var odd = new List<int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            //Using Linq
            //var numeroEven = numbers.Where(x => x % 2 == 0);
            //var numeroOdd = numbers.Where(x => x % 2 != 0);

            
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    even.Add(num);

                }
                else
                {
                    odd.Add(num);

                }
            }

            foreach (var num in even)
            {
                Console.WriteLine($"{num}: is an even number!");

            }

            Console.WriteLine("-------------------------------------");
            foreach (var num in odd)
            {
                Console.WriteLine($"{num}: is an odd number!");
            }
            Console.ReadLine();


        }
    }
}
    
        
 


    



