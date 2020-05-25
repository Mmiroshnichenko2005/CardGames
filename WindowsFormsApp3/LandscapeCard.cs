using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class LandscapeCard
    {
        public enum CardLandscape
        {
            Naboo,
            Jakku,
            Hoth,
            Achto
        }
        public CardLandscape Landscape { get; set; }
        public LandscapeCard(CardLandscape landscape)
        {
            Landscape = landscape;
        }
        public virtual void Show()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return String.Format("{0}", Landscape);
        }
    }
}

    
