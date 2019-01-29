/*
    Author: Matthew Bredahl
    Date: 01/20/2019
    Comments: This C# Console application code demonstrates the use of
              Arrays 
*/

using System;

namespace Deliverable3Array
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declares a variable for the number of values to be in the array; takes the place of user input
            int num = 26;

            try
            {
                int[] myArray = new int[num];

                int pop_array = 0;

                for (int i = 1; i < num; i++)
                {
                    myArray[i] = pop_array;
                    Console.WriteLine("Element value = " + i);

                    //Pauses program for .5 seconds, so the user isn't bombarded with line entries all at once
                    //System.Threading.Thread.Sleep(500);
                }

                Console.WriteLine("Press any key to exit the program . . . ");
                Console.ReadKey(true);
            }//End try
            catch
            {
                Console.WriteLine("An error has occurred");
                Console.WriteLine("Press any key to exit the program and try again . . . ");
                Console.ReadKey(true);
            }//End catch

        }//End Main method
    }//End Program class
}//End Deliverable3Array namespace
