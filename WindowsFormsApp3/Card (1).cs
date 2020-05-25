using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp3
{

    public enum CardLandscape
    {
        Naboo,
        Jakku,
        Hoth,
        Achto
    }
    class Card
    {
        public Card(int character, CardLandscape landscape, int hP, int damage)
        {
            Character = character;
            Landscape = landscape;
            HP = hP;
            Damage = damage;
        }

        public int Character { get; set; }
        public CardLandscape Landscape { get; set; }
        public int HP { get; set; }
        public int Damage { get; set; }


        public virtual void Show()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Character, Landscape);
        }
    }
}
