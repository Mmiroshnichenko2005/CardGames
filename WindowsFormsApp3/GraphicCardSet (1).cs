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

        public GraphicCardSet(Panel panel, CardSetType cardSetType, string directory = @"Cards\") 
            :base(cardSetType, directory)
        {
            Panel = panel;
        }

        public override Card GetCard(string str)
        {
            return new GraphicCard(str);
        }

        public override void Show()
        {
            Panel.Controls.Clear();
            for (int i = 0; i < Cards.Count; i++)
            {
                GraphicCard graphicCard = (GraphicCard)Cards[i];
                PictureBox pb = graphicCard.Pb;
                Label lbl = graphicCard.lblHp;
                Panel.Controls.Add(pb);
                Panel.Controls.Add(lbl);
                pb.BringToFront();
                lbl.BringToFront();

                pb.Size = new Size(Panel.Height * pb.Image.Width/ pb.Image.Height, Panel.Height);
                //lbl.Size = new Size((pb.Height * lbl.Width)/lbl.Height, pb.Height); метка перекрывает так карту
                lbl.AutoSize = true;
                pb.Location = new Point(i * (Panel.Width - pb.Width) / Cards.Count, 0);
                lbl.Font = new Font(lbl.Font.FontFamily, pb.Height / 10);
                lbl.Left = pb.Left + 7 * pb.Width / 10;
                lbl.Top = pb.Top;
                lbl.ForeColor = Color.White;
                lbl.BackColor = Color.DarkBlue;
                pb.TabIndex = i;
                lbl.TabStop = false;
                pb.TabStop = false;
                graphicCard.Show();
            }

        }

    }
}
