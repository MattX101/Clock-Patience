﻿namespace ClockPatience.Objects.Pile
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

        /// <summary>
        /// Prints every Card present on pile
        /// </summary>
        public void PrintCards()
        {
            foreach (Card card in cards)
                card.Print();
        }
    }
}
