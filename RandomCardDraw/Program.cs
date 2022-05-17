using System;

namespace RandomCardDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck.CreateDeck();
            Console.Clear();
            Deck.DrawCards();
        }

    }
}
