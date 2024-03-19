using System;

namespace ClockPatience.Objects
{
    internal class Decks
    {
        private Deck[] _decks;

        private bool _allDecksAreValid = true;

        public Decks(int numOfDecks)
        {
            _decks = new Deck[numOfDecks];
        }

        public void AssignDecks(Deck[] decksToAssign)
        {
            for (int i = 0; i < _decks.Length; i++)
            {
                _decks[i] = decksToAssign[i];

                if (!_decks[i].IsDeckValid)
                    _allDecksAreValid = false;
            }

            if (!_allDecksAreValid)
                Console.WriteLine("Not all decks are valid!\n");
        }

        public void PrintDecks()
        {
            if (!_allDecksAreValid)
                Console.WriteLine("All decks must be valid before they could be printed!");
            else
                foreach (Deck deck in _decks)
                    deck.PrintDeck();

            Console.WriteLine("");
        }
    }
}
