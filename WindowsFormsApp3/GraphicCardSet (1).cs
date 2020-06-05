using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class GraphicCardSet: CardSet
    {
        public Panel Panel { get; set; }

        public GraphicCardSet(Panel panel) : base()
        {
            Panel = panel;
        }

        public GraphicCardSet(Panel panel, int count):this(panel)
        {
            foreach (var name in Enum.GetValues(typeof(Name)))
            {
                foreach (var landscape in Enum.GetValues(typeof(CardLandscape)))
                {
                    Cards.Add(new GraphicCard((CardCharacter)character, (CardLandscape)landscape));
                }
            }
            if (count < Count)
                Cards.RemoveRange(0, Count - count);
        }

        public override void Show()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                GraphicCard graphicCard = (GraphicCard)Cards[i];
                PictureBox pb = graphicCard.Pb;
                Panel.Controls.Add(pb);
                pb.BringToFront();
                pb.Size = new Size(Panel.Height * pb.Image.Width/ pb.Image.Height, Panel.Height);
                pb.Location = new Point(i * (Panel.Width - pb.Width) / Cards.Count, 0);
                pb.TabIndex = i;
                pb.TabStop = false;
                graphicCard.Show();
            }

        }

    }
}
