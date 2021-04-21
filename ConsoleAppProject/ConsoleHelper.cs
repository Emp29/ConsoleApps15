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

            int choiceNo = (int)InputNumber("\n Please enter your choice > ",
                                            1, choices.Length);
            return choiceNo;
        }
        /// <summary>
        /// 
        /// </summary>
        private static void DisplayChoices(string [] choices)
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
            double number = 0;
            bool isValid = false;

            do
            {
                Console.Write(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine(" INVALID NUMBER ENTERED!");
                }
            } while (!isValid);

            return number;
        }

        /// <summary>
        /// 
        /// </summary>
        public static double InputNumber(string prompt, double min, double max)
        {
            bool isValid = false;
            double number = 0;
            
            do
            {
                number = InputNumber(prompt);
                if (number < min || number > max)
                {
                    isValid = false;
                    Console.WriteLine($"Number must be between {min} and {max}");
                }
                else isValid = true;

            } while (!isValid);

            return number;
        }

        /// <summary>
        /// Out put a discription of the application to the user. 
        /// To inform of what app has bein selected. 
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
