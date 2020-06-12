using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class WarCardPlayer:Player
    {
        public WarCardPlayer(string name, GraphicCardSet cardSet, int hP) : base(name, cardSet)
        {
            HP = hP;
        }

        public int HP { get; set; }
    }
}
