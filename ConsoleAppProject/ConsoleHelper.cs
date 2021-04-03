using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {

        /// <summary>
        /// 
        /// </summary>
        public static int SelectChoice(string[] choices)
        {
            // Display the choices

            DisplayChoices(choices);

            // Get the user's choice

            int choiceNo = (int)InputNumber("Please enter your choice > ");
            return choiceNo;
        }
        /// <summary>
        /// 
        /// </summary>
        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"    {choiceNo}.   {choice}");
            }
        }


        public static double InputNumber(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            double number = Convert.ToDouble(value);

            return number;
        }


        /// <summary>
        /// 
        /// </summary>
        public static void OutputHeading(string title)
        {
            Console.WriteLine();
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine($"             {title}    ");
            Console.WriteLine("         by Andrew Wood       ");
            Console.WriteLine("-----------------------------\n");
        }
    }
}
