namespace ClockPatience.Objects.Pile
{
    internal class Pile
    {
        public Card[] cards;

        public Pile(int numOfCardsInPile)
        {
            cards = new Card[numOfCardsInPile];
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
    }
}
