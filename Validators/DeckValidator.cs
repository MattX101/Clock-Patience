using System;

namespace ClockPatience.Validators
{
    internal class DeckValidator
    {
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
