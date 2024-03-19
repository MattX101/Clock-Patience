using System;

namespace ClockPatience.Objects
{
    internal class Card
    {
        private char _rank, _suit;

        public Card(char rank, char suit)
        {
            _rank = rank;
            _suit = suit;
        }

        public void Print()
        {
            Console.Write(char.ToString(_rank) + char.ToString(_suit) + " ");
        }
    }
}
