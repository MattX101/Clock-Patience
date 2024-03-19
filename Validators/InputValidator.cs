using System;
using System.Text.RegularExpressions;

namespace ClockPatience.Validators
{
    internal class InputValidator
    {
        public static string[] ValidateSplitArray(string input)
        {
            string[] strings = input.Split(' ');
            string[] cards = new string[strings.Length];

            int i = 0;
            foreach (string s in strings)
            {
                if (!ValidateString(s))
                {
                    Console.WriteLine(s + " is invalid, only letters or numbers are allowed!");
                }
                else
                {
                    cards[i] = s;
                    i++;
                }
            }

            int invalidStrings = strings.Length - i;
            Console.WriteLine(invalidStrings + " invalid {0} removed!\n",
                invalidStrings == 1 ?
                "string was" :
                "strings were");

            Array.Resize(ref cards, i);
            strings = null;

            return cards;
        }

        private static bool ValidateString(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z0-9]+$");
        }
    }
}
