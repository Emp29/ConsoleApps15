using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class contains methods for converting
    /// different measurements of miles feet and metres
    /// between each other - 6 combination in all.
    /// </summary>
    /// <author>
    /// Andrew Wood 23/01/2021
    /// </author>
    
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        // Distance measured in miles
        private double miles;
        // Distance measured in feet
        private double feet;
        // Distance measured in meters
        private double meters;

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feeet, and output the 
        /// distance in feet.
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading();
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMeters()
        {
            OutputHeading();
            InputMiles();
            CalculateMeters();
            OutputMeters();
        }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("     Convert Miles to Feet    ");
            Console.WriteLine("         by Andrew Wood       ");
            Console.WriteLine("-----------------------------\n");
            Console.WriteLine();
        }

            /// <summary>
            /// Prompt the user to enter the distance in miles
            /// Input the miles as a double number
            /// </summary>
            
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
            
        private void InputMeters()
        {
            Console.Write("Please enter the number of meters > ");
            string value = Console.ReadLine();
            meters = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }
        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateMeters()
        {
            meters = miles * METERS_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine(miles + " feet is " + miles + " miles!");
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputMeters()
        {
            Console.WriteLine(miles + " miles is " + meters + " meters!");
        }
    }
}
