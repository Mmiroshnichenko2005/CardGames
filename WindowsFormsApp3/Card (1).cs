using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
        
        public Card(int money, CardLandscape landscape, int hP, int damage)
        {
            Money = money;
            Landscape = landscape;
            HP = hP;
            Damage = damage;
        }

        public Card(string description)
        {
           // List<CardSet> cs = new List<CardSet>();
          //  cs.Add(new Card(1,CardLandscape.Achto,4,2))
            //from string "1 "
        }

        public int Money { get; set; }
        public CardLandscape Landscape { get; set; }
        public int HP { get; set; }
        public int Damage { get; set; }

        public string Name { get; set; }


        public virtual void Show()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return String.Format("{0}",Name);
        }
    }
}
