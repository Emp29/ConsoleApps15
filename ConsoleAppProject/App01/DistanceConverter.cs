using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class contains methods for converting
    /// different measurements of miles feet and metres (fromUnit) to (toUnit)
    /// between each other - 6 combination in all.
    /// </summary>
    /// <author>
    /// Andrew Wood 23/01/2021
    /// </author>
    /// Version 1.1
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        // Distance measured
        private double fromDistance;
        private double toDistance;

        //Private atributes
        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }
        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feeet, and output the 
        /// distance in feet.
        /// </summary>
        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");

            fromUnit = SelectUnit("Please select the from distance unit > ");
            toUnit = SelectUnit(" Please select the to distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");
            fromDistance = ConsoleHelper.InputNumber($" please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METERS_IN_MILES;
            }
            else if  (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METERS_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string [] choices =
            {
                FEET,
                METRES,
                MILES
            };
            Console.WriteLine(prompt);
            int choiceNo = ConsoleHelper.SelectChoice(choices);

            string unit = choices[choiceNo - 1]; 
            if (unit == null)
                {
                    Console.WriteLine("error");
                } 
            else Console.WriteLine($"\n You have selected {unit}");
            return unit;
        }
        
        /// <summary>
        /// 
        /// </summary>
        private void OutputDistance()   
        {
            Console.WriteLine($"\n {fromDistance}  {fromUnit}" + 
                $" is {toDistance} {toUnit}!\n");
        }
    }
}
