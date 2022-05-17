using System;
namespace RandomCardDraw
{
    public class Card
    {
        public int Number;
        public string Suit;
        public string Color;
        public string Face;

       

        public Card(int number, String suit)
        {
            Number = number;
            Suit = suit;

            if (suit == "Clubs" || suit == "Spades") Color = "Black";
            else Color = "Red";

            if (number == 1) Face = "Ace";
            if (number == 11) Face = "Jack";
            if (number == 12) Face = "Queen";
            if (number == 13) Face = "King";
            //else Face = null;
        }

        public override string ToString()
        {
            if (Number == 1 || Number > 10)
                return $"{Face} of {Suit}";
            else
                return $"{Number} of {Suit}";
        }
    }
}
