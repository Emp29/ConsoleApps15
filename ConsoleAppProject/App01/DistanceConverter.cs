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
    /// Version 1.0
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
            OutputHeading("Converting Miles to Feet");

            miles = InputDistance("please enter the number of miles > ");

            CalculateFeet();

            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");
            feet = InputDistance("please enter the number of feet > ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void MilesToMeters()
        {
            OutputHeading("Converting Miles to Meteres");
            miles = InputDistance("please enter the number of miles > ");
            CalculateMeters();
            OutputDistance(miles, nameof(miles), meters, nameof(meters));
        }

        private void OutputHeading(String prompt)
        {
            Console.WriteLine();
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("        Distance Converter    ");
            Console.WriteLine("         by Andrew Wood       ");
            Console.WriteLine("-----------------------------\n");
            Console.WriteLine();


            Console.WriteLine(prompt);
            Console.WriteLine();
        }
            /// <summary>
            /// Prompt the user to enter the distance in miles
            /// Input the miles as a double number
            /// </summary>
            
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
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
        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance}  {fromUnit}" + 
                $" is {toDistance} {toUnit}!");
        }

    }
}
