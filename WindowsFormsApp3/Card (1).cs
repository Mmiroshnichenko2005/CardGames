using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp3
{
    public enum CardFigure
    {
        low,
        medium,
        high
    }

    public enum CardSuit
    {
        Naboo,
        Jakku,
        Hoth,
        Achto
    }
    class Card
    {
        public CardFigure Figure { get; set; }
        public CardSuit Suit { get; set; }

        public Card(CardFigure figure, CardSuit suit)
        {
            Figure = figure;
            Suit = suit;
        }

        public virtual void Show()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Figure, Suit);
        }
    }
}
