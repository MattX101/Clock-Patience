using System;
using System.Text.RegularExpressions;

namespace ClockPatience
{
    internal class Program
    {
        private static char[] _validRanks = new char[]
        {
            'K', 'Q', 'A', 'J', 'T',
            '2', '3', '4', '5', '6', '7', '8', '9',
        };

        private static char[] _validSuits = new char[]
        {
            'H', 'D', 'C', 'S'
        };

        static void Main(string[] args)
        {
            Console.Write("Enter Deck of cards: ");
            string deck = Console.ReadLine();
            deck = deck.ToUpper();

            Console.WriteLine(
                "Deck was {0}valid",
                !ValidateDeck(deck) ? "not " : "");

            Console.ReadKey();
        }

        private static bool ValidateDeck(string deck)
        {
            bool deckIsValid = true;

            string[] cards = ValidateSplitArray(deck);

            if (cards.Length != 13)
            {
                deckIsValid = false;
                Console.WriteLine("13 cards must be entered! " + cards.Length + " were entered");
                Console.WriteLine("");
            }

            foreach (string card in cards)
            {
                Console.WriteLine(card);

                if (card.Length != 2)
                {
                    deckIsValid = false;
                    Console.WriteLine(card + " is not valid. Must be of length 2!");
                }
                else
                {
                    if (!ValidateRank(card[0]))
                    {
                        deckIsValid = false;
                        Console.WriteLine(card[0] + " is not a valid rank!");
                    }
                    if (!ValidateSuit(card[1]))
                    {
                        deckIsValid = false;
                        Console.WriteLine(card[1] + " is not a valid suit!");
                    }
                }
            }
            Console.WriteLine("");

            if (deckIsValid)
                foreach (string s in cards)
                    Console.Write(s + " ");
            Console.WriteLine("");

            return deckIsValid;
        }

        private static string[] ValidateSplitArray(string deck)
        {
            string[] strings = deck.Split(' ');
            string[] cards = new string[strings.Length];

            int i = 0;
            foreach (string s in strings)
            {
                if (ValidateString(s))
                {
                    cards[i] = s;
                    i++;
                }
            }

            Console.WriteLine(strings.Length - i + " invalid strings were!");
            Array.Resize(ref cards, i);
            strings = null;

            return cards;
        }
        private static bool ValidateString(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z0-9]+$");
        }

        private static bool ValidateRank(char rank)
        {
            bool rankIsValid = false;

            foreach (char validChar in _validRanks)
                rankIsValid = rank.Equals(validChar) ? true : rankIsValid;

            return rankIsValid;
        }

        private static bool ValidateSuit(char suit)
        {
            bool suitIsValid = false;

            foreach (char validSuit in _validSuits)
                suitIsValid = suit.Equals(validSuit) ? true : suitIsValid;

            return suitIsValid;
        }
    }
}
