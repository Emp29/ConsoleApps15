using System;

namespace ConsoleAppProject.App02
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
    public class BMI
    {
        private double height;

        private double weight;

        /// <summary>
        /// d
        /// d
        /// d
        /// d
        /// <summery>
        public void CalculateIndex()
        {
            OutputHeading();
            double BMIIndex = 0;
            int Unit = GetUnits();
            if (Unit == 1) BMIIndex = CalculateMetricBMI();
            else if (Unit == 2) BMIIndex = CalculateImperialBMI();
            OutputHealthMessage(BMIIndex);
        }

        private int GetUnits()
        {
            int unit = 0;
            Console.Write("Enter metric or Imperial > ");
            string value = Console.ReadLine();
            if (String.Equals(value, "metric")) unit = 1;
            else if (String.Equals(value, "imperial")) unit = 2;
            return unit;
        }

        private double CalculateMetricBMI()
        {
            Console.Write("Please enter your height in metres > ");
            string value = Console.ReadLine();
            height = Convert.ToDouble(value);

            Console.Write("please entre your weight in kg > ");
            value = Console.ReadLine();
            weight = Convert.ToDouble(value);

            double index = weight / (height * height);
            return index;
        }

        private void OutputHealthMessage(double BMIIndex)
        {
            Console.Write("Your BMI is > ");
            Console.WriteLine(BMIIndex);

            if (BMIIndex < 18.50) Console.WriteLine ("You are underweight");
            else  if (BMIIndex < 25) Console.WriteLine ("You are normal");
            else  if (BMIIndex < 25) Console.WriteLine ("You are overweight");
            else  if (BMIIndex < 25) Console.WriteLine ("You are obese class 1");
            else  if (BMIIndex < 25) Console.WriteLine ("You are obese class 2");
            else  Console.WriteLine ("You are obese class 3");
        }
        private double CalculateImperialBMI()
        {
            Console.Write("please entre your height in inches > ");
            string value = Console.ReadLine();
            height = Convert.ToDouble(value);

            Console.Write("Please entre your weight in pounds > ");
            value = Console.ReadLine();
            weight = Convert.ToDouble(value);

            double index = weight * 703 / height;
            return index;
        }

        public void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("         BMI Calculator   ");
            Console.WriteLine("         by Andrew Wood       ");
            Console.WriteLine("=-=-=-=-=-=--=-=-=-=-=-=-=-=-=\n");
            Console.WriteLine();
        }

    }
}
