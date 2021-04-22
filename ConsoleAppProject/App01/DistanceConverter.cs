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
        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        //Private atributes
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }

        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }
        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feeet, and output the 
        /// distance in feet.
        /// </summary>
        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");

            FromUnit = SelectUnit("Please select the from distance unit > ");
            ToUnit = SelectUnit(" Please select the to distance unit > ");

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");
            FromDistance = ConsoleHelper.InputNumber($" please enter the number of {FromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        public void CalculateDistance()
        {
            if (FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = FromDistance * METERS_IN_MILES;
            }
            else if  (FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / METERS_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            else if (FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
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
            Console.WriteLine($"\n {FromDistance}  {FromUnit}" + 
                $" is {ToDistance} {ToUnit}!\n");
        }
    }
}
