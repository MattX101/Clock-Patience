using System;
using System.Text.RegularExpressions;

namespace ClockPatience.Validators
{
    internal class InputValidator
    {
        /// <summary>
        /// Based on the number of blank spaces the input is split into multiple strings.
        /// <br /><br />
        /// Checks if the characters are only letters or numbers.<br />
        /// Any invalid strings are removed throughout the process.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Returns a valid string array</returns>
        public static string[] ValidateSplitArray(string input)
        {
            string[] strings = input.Split(' ');
            string[] cards = new string[strings.Length];

            int valids = 0;
            foreach (string s in strings)
            {
                if (!ValidateString(s))
                {
                    Console.WriteLine(s + " is invalid, only letters or numbers are allowed!");
                }
                else
                {
                    cards[valids] = s;
                    valids++;
                }
            }

            int invalidStrings = strings.Length - valids;
            Console.WriteLine(invalidStrings + " invalid {0} removed!\n",
                invalidStrings == 1 ?
                "string was" :
                "strings were");

            Array.Resize(ref cards, valids);
            strings = null;

            return cards;
        }

        /// <summary>
        /// Checks if string contains any non letters or non numbers.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Returns true if the string only contains letters and numbers</returns>
        private static bool ValidateString(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z0-9]+$");
        }
    }
}
