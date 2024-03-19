using System;
using ClockPatience.Data;
using ClockPatience.Objects.Deck;

namespace ClockPatience.Objects.Pile
{
    internal class Piles
    {
        public Pile[] piles;

        private Decks _decks;

        public Piles(int numOfPiles, Decks decks)
        {
            piles = new Pile[numOfPiles];
            _decks = decks;
        }

        public void AssignPiles(int totalNumOfCards, int numOfCardsPerDeck, int numOfDecks)
        {
            for (int i = 0; i < piles.Length; i++)
                AssignPile(totalNumOfCards, numOfCardsPerDeck, numOfDecks, i);

            // Prints all cards that have the same Rank as the array value
            for (int i = 0; i < piles.Length; i++)
            {
                Console.Write("{0} - ", ValidRanks.Instance.Ranks[i]);
                piles[i].PrintCards();
                Console.WriteLine("");
            }
        }

        private void AssignPile(int totalNumOfCards, int numOfCardsPerDeck, int numOfDecks, int i)
        {
            piles[i] = new Pile(totalNumOfCards / numOfCardsPerDeck, ValidRanks.Instance.Ranks[i]);

            for (int j = 0; j < numOfDecks; j++)
                piles[i].AssignCard(_decks.DecksObject[j].cards[i], j);
        }
    }
}
