namespace ClockPatience.Objects.Deck
{
    internal class Decks
    {
        private Deck[] _decks;
        public Deck[] DecksObject
        {
            get => _decks;
        }

        public bool AllDecksAreValid = true;

        private int _totalNumOfCards;
        public int TotalNumOfCards
        {
            get => _totalNumOfCards;
        }

        public Decks(int numOfDecks)
        {
            _decks = new Deck[numOfDecks];
        }

        public void AssignDeck(Deck deckToAssign, int index)
        {
            _decks[index] = deckToAssign;

            if (!_decks[index].IsDeckValid)
                AllDecksAreValid = false;
            else
                _totalNumOfCards += _decks[index].cards.Length;
        }

        public void PrintDecks()
        {
            foreach (Deck deck in _decks)
                deck.PrintDeck();
        }
    }
}
