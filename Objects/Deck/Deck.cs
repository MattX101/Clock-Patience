using System;
using ClockPatience.Validators;
using ClockPatience.DataInput;
using ClockPatience.Data;

namespace ClockPatience.Objects.Deck
{
    internal class Deck
    {
        public Card[] cards;

        public bool IsDeckValid = true;

        public Deck(int numOfCards)
        {
            cards = new Card[numOfCards];
            
            Console.Write("Enter Deck of cards: ");
            string deckInput = Input.Instance.Enter().ToUpper();
            Console.WriteLine("");

            string[] values = InputValidator.ValidateSplitArray(deckInput);
            if (!DeckValidator.ValidateDeck(values, numOfCards))
                IsDeckValid = false;
            
            AddCards(values);

            Console.WriteLine("");
        }

        public Deck(int numOfCards, string input)
        {
            cards = new Card[numOfCards];

            string[] values = InputValidator.ValidateSplitArray(input);
            if (!DeckValidator.ValidateDeck(values, numOfCards))
                IsDeckValid = false;

            AddCards(values);

            Console.WriteLine("");
        }

        public void AddCards(string[] values)
        {
            for (int i = 0; i < values.Length; i++)
                cards[i] = AddCard(values[i]);

            Console.WriteLine(
                "\nDeck was {0}valid\n",
                IsDeckValid ? "" : "not ");
        }

        private Card AddCard(string value)
        {
            Console.WriteLine(value);

            if (value.Length != 2)
            {
                IsDeckValid = false;
                Console.WriteLine(value + " is not valid. Must be of length 2!");

                return null;
            }

            bool rankIsValid = CardValidator.ValidateChar(value[0], ValidRanks.Instance.Ranks, "Rank");
            bool suitIsValid = CardValidator.ValidateChar(value[1], ValidSuits.Instance.Suits, "Suit");

            if (rankIsValid && suitIsValid)
                return new Card(value[0], value[1]);

            IsDeckValid = false;
            return null;
        }

        public void PrintDeck()
        {
            foreach (Card card in cards)
                card.Print();
            Console.WriteLine("");
        }
    }
}
