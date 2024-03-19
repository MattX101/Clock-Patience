using System;
using ClockPatience.DataInput;
using ClockPatience.Objects;

namespace ClockPatience
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();

            int numOfDecks = 4;
            int numOfCardsPerDeck = 13;

            Decks decks = new Decks(numOfDecks);
            decks.AssignDecks(
                new Deck[] 
                {
                    new Deck(numOfCardsPerDeck, input),
                    new Deck(numOfCardsPerDeck, input),
                    new Deck(numOfCardsPerDeck, input),
                    new Deck(numOfCardsPerDeck, input)
                });

            decks.PrintDecks();

            Console.WriteLine("Press any key to exit application...");
            Console.ReadKey();
        }
    }
}
