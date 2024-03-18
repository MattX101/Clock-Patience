using System;

namespace ClockPatience
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Deck of cards: ");
            string deck = Console.ReadLine();
            deck = deck.ToUpper();

            Console.WriteLine("");
            Console.WriteLine("Deck: " + deck);

            Console.ReadKey();
        }
    }
}
