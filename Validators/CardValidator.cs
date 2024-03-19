using System;

namespace ClockPatience.Validators
{
    internal class CardValidator
    {
        /// <summary>
        /// Checks the character with an array of valid characters. <br/>
        /// Used to check to check both the Rank and Suit of a card.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="validChars"></param>
        /// <param name="type"></param>
        /// <returns>Returns true if the character is found in the valid characters array</returns>
        public static bool ValidateChar(char c, char[] validChars, string type)
        {
            bool valid = false;
            foreach (char validChar in validChars)
                valid = c.Equals(validChar) ? true : valid;

            if (!valid)
            {
                Console.WriteLine(c + " is not a valid {0}!", type);
                return false;
            }

            return true;
        }
    }
}
