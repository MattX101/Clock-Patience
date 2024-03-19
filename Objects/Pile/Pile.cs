using ClockPatience.Data;
using System;

namespace ClockPatience.Objects.Pile
{
    internal class Pile
    {
        public Card[] cards;

        public char id;

        public int currentExposedCard = 3;

        public Pile(int numOfCardsInPile, char id)
        {
            cards = new Card[numOfCardsInPile];
            this.id = id;
        }

        public void AssignCard(Card card, int index)
        {
            cards[index] = card;
        }

        public void PrintCards()
        {
            foreach (Card card in cards)
                card.Print();
        }

        public void GetMapValue()
        {
            foreach (Card card in cards)
                Console.Write(PileMapping.Map[card.Rank] + " ");
        }
    }
}
