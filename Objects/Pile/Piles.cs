using System;
using ClockPatience.Objects.Deck;

namespace ClockPatience.Objects.Pile
{
    internal class Piles
    {
        public Pile[] piles;

        private Decks _decks;

        char[] ids = new char[13]
        {
            'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K'
        };

        public Piles(int numOfPiles, Decks decks)
        {
            piles = new Pile[numOfPiles];
            _decks = decks;
        }

        public void AssignPiles(int totalNumOfCards, int numOfCardsPerDeck, int numOfDecks)
        {
            for (int i = 0; i < piles.Length; i++)
                AssignPile(totalNumOfCards, numOfCardsPerDeck, numOfDecks, i);

            for (int i = 0; i < piles.Length; i++)
            {
                Console.Write("{0} - ", ids[i]);
                piles[i].PrintCards();
                Console.WriteLine("");
            }
        }

        private void AssignPile(int totalNumOfCards, int numOfCardsPerDeck, int numOfDecks, int i)
        {
            piles[i] = new Pile(totalNumOfCards / numOfCardsPerDeck, ids[i]);

            for (int j = 0; j < numOfDecks; j++)
                piles[i].AssignCard(_decks.DecksObject[j].cards[i], j);
        }
    }
}
