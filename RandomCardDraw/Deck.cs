using System;
using System.Collections.Generic;
namespace RandomCardDraw
{
    public class Deck
    {
        static public Card[] theDeck = new Card[52];

        static public void CreateDeck()
        {
            string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
            int deckIndex = 0;
            foreach(var suit in suits)
            {
            for(int i = 1; i<=13;i++)
                {
                theDeck[deckIndex] = new Card(i, suit);
                deckIndex++;
                }
            }
        }

        static public void DrawCards(int numOfCards=10)
        {
            if (numOfCards > 52)
            {
                Console.WriteLine("Must be 1-52! There is only 52 cards in the deck!!!");
                return;
            }
            Card[] drawnCards = new Card[numOfCards];
            List<int> randomList = new List<int>();
            Random RandomNum = new Random();
            int RNumber;
            for (int i = 1;i<=numOfCards;i++)
            {
                RNumber = RandomNum.Next(0, 52);
                while (randomList.Contains(RNumber))
                    RNumber = RandomNum.Next(0, 52);
                randomList.Add(RNumber);
                Console.WriteLine(theDeck[RNumber]);
            }
        }
    }
    
}
