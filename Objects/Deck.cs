using System;

namespace ClockPatience.Objects
{
    internal class Deck
    {
        private readonly char[] _validRanks = new char[]
        {
            'K', 'Q', 'A', 'J', 'T',
            '2', '3', '4', '5', '6', '7', '8', '9',
        };

        private readonly char[] _validSuits = new char[]
        {
            'H', 'D', 'C', 'S'
        };

        public Card[] cards;

        private bool _deckIsValid = true;
        public bool IsDeckValid
        { 
            get => _deckIsValid;  
        }

        public Deck(int numOfCards)
        {
            cards = new Card[numOfCards];
        }

        public void AddCards(string[] cards)
        {
            for (int i = 0; i < cards.Length; i++)
                this.cards[i] = AddCard(cards[i]);

            Console.WriteLine(
                "\nDeck was {0}valid\n",
                _deckIsValid ? "" : "not ");
        }

        public Card AddCard(string card)
        {
            Console.WriteLine(card);

            if (card.Length != 2)
            {
                _deckIsValid = false;
                Console.WriteLine(card + " is not valid. Must be of length 2!");

                return null;
            }

            bool rankIsValid = ValidateChar(card[0], _validRanks, "Rank");
            bool suitIsValid = ValidateChar(card[1], _validSuits, "Suit");
            if (rankIsValid && suitIsValid)
                return new Card(card[0], card[1]);

            _deckIsValid = false;

            return null;
        }

        private bool ValidateChar(char c, char[] validChars, string type)
        {
            bool valid = false;

            foreach (char validChar in validChars)
                valid = c.Equals(validChar) ? true : valid;

            if (!valid)
            {
                _deckIsValid = false;
                Console.WriteLine(c + " is not a valid {0}!", type);
            }

            return valid;
        }
    }
}
