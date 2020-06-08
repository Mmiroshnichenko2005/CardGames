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
            //"RedHorseKnight 2 Jakku 4 2"
            string[] s = description.Split(' ');
            Name = s[0];
            Money = Convert.ToInt32(s[1]);
            Landscape = FromString(s[2]);
            HP = Convert.ToInt32(s[3]); 
            Damage = Convert.ToInt32(s[4]);
        }

        public int Money { get; set; }
        public CardLandscape Landscape { get; set; }
        public int HP { get; set; }
        public int Damage { get; set; }

        public string Name { get; set; }


        public CardLandscape FromString(string landScapeString)
        {
            switch (landScapeString)
            {
                case "Naboo": 
                    return CardLandscape.Naboo;
                case "Jakku":
                    return CardLandscape.Jakku;
                case "Hoth":
                    return CardLandscape.Hoth;
                case "Achto":
                    return CardLandscape.Achto;
                default: return default;
            }
        }

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
