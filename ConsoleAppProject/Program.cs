﻿using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Andrew Wood 23/01/2021
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();
        private static BMI calculator = new BMI();


        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Beep();

            ConsoleHelper.OutputHeading(" BNU CO453 Applications Programming 2020-2021!");

            string[] choices = { "Distance Converter", "BMI Calculator", "Student Grades" };
            int choiceNo = ConsoleHelper.SelectChoice(choices);

            if (choiceNo == 1)
            {
                converter.ConvertDistance();
            }

            if (choiceNo == 2)
            {
                calculator.CalculateIndex();
            }
            else if (choiceNo == 3)
            {
                
            }
            else if (choiceNo == 4)
            {

            }
            else Console.WriteLine(" INVALID SELECTION CHOOSEN");


        }
    }
}
