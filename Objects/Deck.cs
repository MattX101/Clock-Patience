using System;
using ClockPatience.Validators;
using ClockPatience.Data;

namespace ClockPatience.Objects
{
    internal class Deck
    {
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

        private Card AddCard(string card)
        {
            Console.WriteLine(card);

            if (card.Length != 2)
            {
                _deckIsValid = false;
                Console.WriteLine(card + " is not valid. Must be of length 2!");

                return null;
            }

            bool rankIsValid = CardValidator.ValidateChar(card[0], ValidRanks.Ranks, "Rank");
            bool suitIsValid = CardValidator.ValidateChar(card[1], ValidSuits.Suits, "Suit");
            
            if (rankIsValid && suitIsValid)
                return new Card(card[0], card[1]);

            _deckIsValid = false;

            return null;
        }
    }
}
