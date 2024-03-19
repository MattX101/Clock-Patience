using System;

namespace ClockPatience.Validators
{
    internal class CardValidator
    {
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
