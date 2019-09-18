/*
    Author: Derrick Burns
    Date: 9/18/2019
    Comments: This C# Console appplication demonstrates the use of Arrays
*/

using System;

namespace Deliverable3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declared numbersArray
            int[] numbersArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25};
            // Used to foreach loop to iterate through the array and write result of each element
            foreach (int i in numbersArray)
            {
                Console.WriteLine("Element value = " + i);
            }
            // Writeline to command to exit the program
            Console.WriteLine("\nPress any key to exit the program.");
        }
    }
}
