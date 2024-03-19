using System;
using ClockPatience.DataInput;
using ClockPatience.Objects;
using ClockPatience.Validators;

namespace ClockPatience
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();

            Console.Write("Enter Deck of cards: ");
            string deckInput = input.Enter().ToUpper();
            Console.WriteLine("");

            string[] cards = InputValidator.ValidateSplitArray(deckInput);
            if (DeckValidator.ValidateDeck(cards))
            {
                Deck deck = new Deck(cards.Length);
                deck.AddCards(cards);
            }

            Console.ReadKey();
        }
    }
}
