using System;
using ClockPatience.Data;
using ClockPatience.Objects;
using ClockPatience.Objects.Deck;
using ClockPatience.Objects.Pile;

namespace ClockPatience
{
    internal class Program
    {
        private static int _numOfDecks = 4;
        private static int _numOfCardsPerDeck = 13;
        private static int _numOfPile = 13;

        private static Decks _decks = new Decks(_numOfDecks);
        private static Piles _piles = new Piles(_numOfPile, _decks);

        static void Main(string[] args)
        {
            PredefinedOutcome();

            if (!_decks.AllDecksAreValid)
            {
                Console.WriteLine("All decks must be valid before they could be printed!");
            }
            else
            {
                Console.WriteLine("Decks");
                _decks.PrintDecks();
                Console.WriteLine("");

                Console.WriteLine("Cards sorted by piles");
                _piles.AssignPiles(_decks.TotalNumOfCards, _numOfCardsPerDeck, _numOfDecks);
                Console.WriteLine("");

                Play();
            }

            Console.WriteLine("\nPress any key to exit application...");
            Console.ReadKey();
        }

        private static void UserInput()
        {
            for (int i = 0; i < _numOfDecks; i++)
                _decks.AssignDeck(new Deck(_numOfCardsPerDeck), i);
        }

        private static void PredefinedOutcome()
        {
            string deck1 = "TS QC 8S 8D QH 2D 3H KH 9H 2H TH KS KC";
            string deck2 = "9D JH 7H JD 2S QS TD 2C 4H 5H AD 4D 5D";
            string deck3 = "6D 4S 9S 5S 7S JS 8H 3D 8C 3S 4C 6S 9C";
            string deck4 = "AS 7C AH 6H KD JC 7D AC 5C TC QD 6C 3C";

            _decks.AssignDeck(new Deck(_numOfCardsPerDeck, deck1), 0);
            _decks.AssignDeck(new Deck(_numOfCardsPerDeck, deck2), 1);
            _decks.AssignDeck(new Deck(_numOfCardsPerDeck, deck3), 2);
            _decks.AssignDeck(new Deck(_numOfCardsPerDeck, deck4), 3);
        }

        private static void Play()
        {
            Console.WriteLine("Order of exposed cards");

            int count = 0;

            int index = 12;
            int unexposedIndex = _piles.piles[index].currentExposedCard;
            Card current = _piles.piles[index].cards[unexposedIndex];
            while (true)
            {
                _piles.piles[index].currentExposedCard--;

                current.Print();
                current.Exposed = true;
                count++; 

                if (unexposedIndex <= 0)
                {
                    break;
                }
                else
                {
                    index = PileMapping.Instance.Map[current.Rank];
                    unexposedIndex = _piles.piles[index].currentExposedCard;
                    current = _piles.piles[index].cards[unexposedIndex];
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Output - " + count + "," + current.Rank + current.Suit);
            Console.WriteLine("");

            Console.WriteLine("Number of unexposed cards per Rank");
            foreach (Pile pile in _piles.piles)
                Console.WriteLine(pile.id + " - " + (pile.currentExposedCard + 1));
        }
    }
}
