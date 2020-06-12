using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WindowsFormsApp3
{
    enum CardSetType
    {
        Empty,
        File
    }
    class CardSet
    {
        public List<Card> Cards { get; set; }

        protected int Count
        {
            get { return Cards.Count; }
        }

        public CardSet(List<Card> cards)
        {
            this.Cards = cards;
        }

        public CardSet() : this(new List<Card>())
        { }

        public CardSet(CardSetType cardSetType, string directory=@"bin\Debug\Cards") : this()
        {
            if (cardSetType == CardSetType.Empty) return;

            //Набрать карты
            try
            {
                StreamReader streamReader = new StreamReader(directory + "descriptions.txt");
                Cards = GetCardsFromFile(streamReader);
                streamReader.Close();
            }
            catch
            {
                throw new Exception("directory with cards is incorrect");
            }
        }

        private List<Card> GetCardsFromFile(StreamReader streamReader)
        {
            List<Card> cards = new List<Card>();
            var allFile = streamReader.ReadToEnd();
            string[] lines = allFile.Split('\n');
            foreach (var line in lines)
            {
                cards.Add(GetCard(line.Trim()));
            }
            return cards;
        }

        public virtual Card GetCard(string str)
        {
            return new Card(str);
        }

        public void Mix()
        {
            Random rnd = new Random();
            List<Card> newCards = new List<Card>();

            for (int i = Cards.Count; i > 0; i--)
            {
                Card a = Cards[rnd.Next(0, Cards.Count)];
                newCards.Add(a);
                Cards.Remove(a);
            }

            Cards = newCards;
        }

        public Card Pull()
        {
            return Pull(0);
        }

        public Card Pull(int number)
        {
            if (number > Count - 1) return null;

            Card a = Cards[number];
            Cards.RemoveAt(number);
            return a;
        }

        public Card Pull(Card card)
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
            card1.Money.CompareTo(card2.Money) == 0 ?
            card1.Landscape.CompareTo(card2.Landscape) :
            card1.Money.CompareTo(card2.Money)
                );
        }

        public CardSet Deal(int amount)
        {
            CardSet c = new CardSet();
            if (amount > Cards.Count) amount = Cards.Count;

            for (int i = 0; i < amount; i++)
            {
                c.Add(Cards[0]);
                Cards.RemoveAt(0);
            }

            return c;
        }

        public void Add(params Card[] card)
        {
            foreach (var item in card)
            {
                Cards.Add(item);
            }
        }

        public void Add(CardSet cards)
        {
            Add(cards.Cards.ToArray());
        }
    }
}
