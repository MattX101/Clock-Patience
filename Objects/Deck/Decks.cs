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

        /// <summary>
        /// Takes a deck and assigns it to the array
        /// </summary>
        /// <param name="deckToAssign"></param>
        /// <param name="index"></param>
        public void AssignDeck(Deck deckToAssign, int index)
        {
            _decks[index] = deckToAssign;

            if (!_decks[index].IsDeckValid)
                AllDecksAreValid = false;
            else
                _totalNumOfCards += _decks[index].cards.Length;
        }

        /// <summary>
        /// Loops through every single deck and prints every card Rank and Suit
        /// </summary>
        public void PrintDecks()
        {
            foreach (Deck deck in _decks)
                deck.PrintDeck();
        }
    }
}
