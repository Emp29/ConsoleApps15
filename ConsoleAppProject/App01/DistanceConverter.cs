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
            fromUnit = SelectUnit("Please select the from distance unit > ");
            toUnit = SelectUnit("Please select the to distance unit > ");

            OutputHeading($"Converting{fromUnit} to {toUnit}");

            fromDistance = InputDistance($"please enter the number of {fromUnit} > ");

            //CalculateFeet();

            OutputDistance();
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            return ExecuteChoice(choice);
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return = FEET;
            }
            else if (choice == "2")
            {
                return = METRES;
            }
            else if (choice.Equals("3"))
            {
                return = MILES;
            }
            return null;
        }

        private static string NewMethod(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
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
        private void OutputDistance()   
        {
            Console.WriteLine($" {fromDistance}  {fromUnit}" + 
                $" is {toDistance} {toUnit}!");
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

    }
}
