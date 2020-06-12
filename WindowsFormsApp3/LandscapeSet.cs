using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class LandscapeSet
    {
        public List<LandscapeCard> Cards { get; set; }

        protected int Count
        {
            get { return Cards.Count; }
        }

        public LandscapeSet(List<LandscapeCard> cards)
        {
            this.Cards = cards;
        }

        public LandscapeSet() : this(new List<LandscapeCard>())
        { }

        public LandscapeSet(int count) : this()
        {
            foreach (var landscape in Enum.GetValues(typeof(LandscapeCard)))
            {
                Cards.Add(new LandscapeCard((CardLandscape)landscape));
            }
            if (count < Count)
                Cards.RemoveRange(0, Count - count);
        }


        public void Mix()
        {
            
        }

        

        public Card Pull(int number)
        {
            //if (number > Count - 1) return null;

            //LandscapeCard a = Cards[number];
            //Cards.RemoveAt(number);
            //return a;
        }

        public Card Pull(LandscapeCard card)
        {
            int ind = Cards.IndexOf(card);
            if (ind == -1) throw new Exception("Card's not find from cardset");
            return Pull(ind);
        }

        public virtual void Show()
        {
            foreach (var item in Cards)
            {
                item.Show();
            }

        }

        public virtual void Sort()
        {
            Cards.Sort((card1, card2) =>
            card1.Landscape.CompareTo(card2.Landscape) == 0 ?
            card1.Landscape.CompareTo(card2.Landscape) :
            card1.Landscape.CompareTo(card2.Landscape)
                );
        }

        public LandscapeSet Deal(int amount)
        {
            LandscapeSet c = new LandscapeSet();
            if (amount > Cards.Count) amount = Cards.Count;

            for (int i = 0; i < amount; i++)
            {
                c.Add(Cards[i]);
                Cards.RemoveAt(i);
            }

            return c;
        }

        public void Add(params LandscapeCard[] card)
        {
            foreach (var item in card)
            {
                Cards.Add(item);
            }
        }

        public void Add(LandscapeSet cards)
        {
            Add(cards.Cards.ToArray());
        }
    }
}
