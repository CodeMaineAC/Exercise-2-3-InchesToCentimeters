using static System.Console;
using System;
/*
 * Exercise C# 2-3 Inches to Centimeters v2
 * 12/16/2020
 * Prompts user for a measurement in inches and converts to centimeters. 
 * 
 * This example uses TryParse to check to see if user input is of a valid
 * type.
 */
namespace Exercise_2_3_InchesToCentimeters
{
    class InchesToCentimetersInteractive
    {
        static void Main(string[] args)
        {
            const double CENTIMETERS_PER_INCH = 2.54;

            Write("Measurement in inches: "); // prompt for the user
            bool notParsed = true;
            
            while(notParsed)
            {
                /*
                 * TryParse checks to see if a string can be converted to a particular Data Type
                 * if it returns true it will also output the value of the data type it is converting to.
                 * 
                 * In this example the TryParse check to see if the user input can be converted to a
                 * double, and if that is true, it outputs the results to the variable inches.
                 */
                if (Double.TryParse(ReadLine(), out double inches)) 
                {
                    WriteLine("{0} inches is {1} centimeters", inches, inches * CENTIMETERS_PER_INCH);
                    notParsed = false;
                }
                else
                {
                    WriteLine("Incorrect input, try again");
                    Write("Measurement in inches: ");
                }
            }

           
        }
    }
}
