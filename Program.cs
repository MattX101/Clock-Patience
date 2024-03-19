using ClockPatience.Objects;
using System;
using System.Text.RegularExpressions;

namespace ClockPatience
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Deck of cards: ");
            ValidateDeck(InputDeck());

            Console.ReadKey();
        }

        private static string InputDeck()
        {
            return Console.ReadLine().ToUpper();
        }

        private static bool ValidateDeck(string input)
        {
            string[] cards = ValidateSplitArray(input);

            if (cards.Length != 13)
            {
                Console.WriteLine("13 cards must be entered! " + cards.Length + " were entered!\n");
                return false;
            }

            Deck deck = new Deck(cards.Length);
            deck.AddCards(cards);

            return deck.IsDeckValid;
        }

        private static string[] ValidateSplitArray(string input)
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
