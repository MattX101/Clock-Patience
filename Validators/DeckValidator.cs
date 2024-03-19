using System;

namespace ClockPatience.Validators
{
    internal class DeckValidator
    {
        private static byte requiredCount = 13;

        public static bool ValidateDeck(string[] cards)
        {
            if (cards.Length != requiredCount)
            {
                Console.WriteLine(("{0} cards must be entered! " + cards.Length + " were entered!\n"), requiredCount);
                return false;
            }

            return true;
        }
    }
}
