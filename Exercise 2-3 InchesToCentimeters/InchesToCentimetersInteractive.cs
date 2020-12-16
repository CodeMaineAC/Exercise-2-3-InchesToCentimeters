using static System.Console;
using System;
/*
 * Exercise C# 2-3 Inches to Centimeters
 * 12/16/2020
 * Prompts user for a measurement in inches and converts to centimeters
 */
namespace Exercise_2_3_InchesToCentimeters
{
    class InchesToCentimetersInteractive
    {
        static void Main(string[] args)
        {
            const double CENTIMETERS_PER_INCH = 2.54;

            WriteLine("Measurement in inches: "); // prompt for the user

            double inches = Convert.ToDouble(ReadLine()); //get user input and convert to double

            WriteLine("{0} inches is {1} centimeters", inches, inches * CENTIMETERS_PER_INCH);
        }
    }
}
