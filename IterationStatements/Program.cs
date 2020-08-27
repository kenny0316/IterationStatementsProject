using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0



            // Create a do-while loop
            var i = 0;
            do
            {
                i++;
            } while (i < 100);




            // Create a while loop
            // While your variable is less than 200
            int num = 0;
            while (num < 200)
            {
                num++;
            }
            Console.WriteLine("Increase:");

           // Increment your variable by 1
            // Then add your variable to "numbers"

            Console.WriteLine("Increase:");


            foreach (var item in numbers)
            {
                Console.WriteLine("item");
            }
            // Create a foreach loop
            // Write your variable to the console

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1

            for( i = 199; i >= 0; i--)
            {
                Console.WriteLine("numbers");                       // Write to the console "numbers" at index i
            }
        }
    }
}
