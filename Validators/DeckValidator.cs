using System;

namespace ClockPatience.Validators
{
    internal class DeckValidator
    {
        /// <summary>
        /// Checks if the number of cards entered are equal to the needed amount.
        /// </summary>
        /// <param name="cards"></param>
        /// <param name="validCardCount"></param>
        /// <returns>Returns true if the right amount of cards are entered</returns>
        public static bool ValidateDeck(string[] cards, int validCardCount)
        {
            if (cards.Length != validCardCount)
            {
                Console.WriteLine(("{0} cards must be entered! " + cards.Length + " were entered!\n"), validCardCount);
                return false;
            }

            return true;
        }
    }
}
