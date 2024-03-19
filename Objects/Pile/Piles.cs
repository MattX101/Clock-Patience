using System;
using ClockPatience.Objects.Deck;

namespace ClockPatience.Objects.Pile
{
    internal class Piles
    {
        private Pile[] _piles;

        private Decks _decks;

        public Piles(int numOfPiles, Decks decks)
        {
            _piles = new Pile[numOfPiles];
            _decks = decks;
        }

        public void AssignPiles(int totalNumOfCards, int numOfCardsPerDeck, int numOfDecks)
        {
            for (int i = 0; i < _piles.Length; i++)
                AssignPile(totalNumOfCards, numOfCardsPerDeck, numOfDecks, i);

            for (int i = 0; i < _piles.Length; i++)
            {
                _piles[i].PrintCards();
                Console.WriteLine("");
            }
        }

        private void AssignPile(int totalNumOfCards, int numOfCardsPerDeck, int numOfDecks, int i)
        {
            _piles[i] = new Pile(totalNumOfCards / numOfCardsPerDeck);

            for (int j = 0; j < numOfDecks; j++)
                _piles[i].AssignCard(_decks.DecksObject[j].cards[i], j);
        }
    }
}
