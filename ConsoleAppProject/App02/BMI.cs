using System;

namespace ConsoleAppProject.App02
{


    /// <summary>
    /// This class contains methods for calculating Body Mass Index.
    /// </summary>
    /// <author>
    /// Andrew Wood 23/01/2021
    /// </author>
    /// Version 1.1
    public class BMI
    {
        //Constants for how many pounds in a stone
        //and how many inches in a foot.
        public const int POUNDS_IN_STONES = 14;
        public const int INCHES_IN_FEET = 12;

        //Constants to define limit values as defined in the WHO weight table.
        public const double UNDERWEIGHT = 18.5;
        public const double NORMAL = 24.9;
        public const double OVERWEIGHT = 29.9;
        public const double OBESE_CLASS_I = 34.9;
        public const double OBESE_CLASS_II = 39.9;
        public const double OBESE_CLASS_III = 40.0;

        //Imperial and Metric variables
        private double pound;
        private int inch;
        private double kilogram;
        private double metre;
        private double stone;

        //BMI Index
        public double BMIIndex;

        /// <summary>
        /// d
        /// d
        /// d
        /// d
        /// <summery>
        public void CalculateIndex()
        {
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");

            //Select units method called to make the unit choice
            UnitSystems unitSystem = SelectUnits();

            //Decision made of choice - imperial or metric
            if (unitSystem == UnitSystems.Imperial)
            {
                InputImperialDetails();
                CalculateImperialBMI();
            }
            else
            {
                InputMetricDetails();
                CalculateMetricBMI();
            }
            //Output the required messages for BMI calculations
            //and if you are BAME therefore are at a higher risk

            OutputHealthMessage();
            OutputBameMessage();

        }
        /// <summary>
        /// Get the Users choice of Imperial or Metric
        /// </summary>
        /// <returns></returns>
        private UnitSystems SelectUnits()
        {
            Console.WriteLine("1. Imperial Units");
            Console.WriteLine("2. Metric Units");

            Console.Write("\n Choose your unit type > ");
            string typeChoice = Console.ReadLine();

            if (typeChoice == "1") return UnitSystems.Imperial;
            else return UnitSystems.Metric;
        }
        public void CalculateMetricBMI()
        {
            BMIIndex = kilogram / (metre * metre);
        }

        public void CalculateImperialBMI()
        {
            BMIIndex = pound * 703 / (inch * inch);
        }

        /// <summary>
        /// Method prompts user and 
        /// allows input of a number 
        /// converted to a double
        /// </summary>
        public double InputNumber(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            double number = Convert.ToDouble(value);
            return number;
        }

        private void InputImperialDetails()
        {
            Console.Write("Input your weight (stone and pounds) \n");
            double stone = InputNumber("Input weight in Stones > ");
            pound = InputNumber("Imput weight in pounds > ");
            pound += stone * POUNDS_IN_STONES;

            Console.WriteLine("Input your height (feet and inches) \n");
            double feet = InputNumber("Input hight in Feet > ");
            inch = (int)InputNumber("Input hight in Inches > ");
            inch += (int)feet * INCHES_IN_FEET;
        }

        /// <summary>
        /// Input metric value for
        /// height in metres and
        /// weight in kilograms.
        /// </summary>
        private void InputMetricDetails()
        {
            metre = InputNumber("Input height in metres > ");
            kilogram = InputNumber("Input weight in kilograms > ");
        }

        private void OutputHealthMessage()
        {
            //Console.Write("Your BMI is > ");
            //Console.WriteLine(BMIIndex);

            if (BMIIndex < UNDERWEIGHT)
            {
                Console.WriteLine($"BMI is {BMIIndex:0.00}, therefore" +
                    $"you are classed as underweight.");
            }
            else if (BMIIndex <= NORMAL)
            {
                Console.WriteLine($"BMI is {BMIIndex:0.00}, therefore" +
                    $"you are classed as having normal weight.");
            }
            else if (BMIIndex <= OVERWEIGHT)
            {
                Console.WriteLine($"BMI is {BMIIndex:0.00}, therefore" +
                    $"you are classed as being Overweight.");
            }
            else if (BMIIndex <= OBESE_CLASS_I)
            {
                Console.WriteLine($"BMI is {BMIIndex:0.00}, therefore" +
                    $"you are classed as being Obese Class I .");
            }
            else if (BMIIndex <= OBESE_CLASS_II)
            {
                Console.WriteLine($"BMI is {BMIIndex:0.00}, therefore" +
                    $"you are classed as being Obese Class II .");
            }
            else if (BMIIndex <= OBESE_CLASS_III)
            {
                Console.WriteLine($"BMI is {BMIIndex:0.00}, therefore" +
                    $"you are classed as being Obese Class III .");
            }

        }

        /// <summary>
        /// Output explination for the BAME 
        /// </summary>
        public void OutputBameMessage()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("     There are higher risks for");
            Console.WriteLine(" Black, Asian or other minority people");
            Console.WriteLine("=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine(" Your ethnicity means that excess");
            Console.WriteLine(" weight can put you at higher risk of ");
            Console.WriteLine("health problems like type 2 diabetes, heart disease and stroke.");
            Console.WriteLine("=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("If you're concerned about your weight speak to your GP");
        }
    }
}