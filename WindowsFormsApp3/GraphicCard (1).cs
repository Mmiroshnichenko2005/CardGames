using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class GraphicCard : Card
    {
        public PictureBox Pb { get; set; }
        public Label lblHp{get;set;}
        public bool Opened
        {
            get
            {
                return opened;
            }
            set
            {
                opened = value;
                Pb.Image = opened ? Image.FromFile(fileName) : Image.FromFile(imageShirtPath);
                lblHp.Text = HP.ToString();
            }
        }

        private bool opened;
        private readonly string imageShirtPath = Application.StartupPath + @"\Cards\shirt.png";
        private readonly string fileName;

        public GraphicCard(int money, CardLandscape landscape, int hP, int damage, PictureBox pb, Label lb, bool opened = true):base(money,landscape,hP,damage)
        {
            lblHp = lb;
            Pb = pb;
            Pb.SizeMode = PictureBoxSizeMode.Zoom;
            Pb.Visible = false;
            fileName = Application.StartupPath + @"\Cards\" + this.ToString() + ".png";
            Opened = opened;
        }

        public GraphicCard(string description, PictureBox pb, Label lb):base(description)
        {
            Pb = pb;
            lblHp = lb;
            Pb.SizeMode = PictureBoxSizeMode.Zoom;
            Pb.Visible = false;
            fileName = Application.StartupPath + @"\Cards\" + this.ToString() + ".png";
        }

        public GraphicCard(string description) : this(description, new PictureBox(), new Label())
        { }

        //public GraphicCard(CardLandscape landscape) : this(landscape, new PictureBox()) { }

        public override void Show()
        {
            Pb.Visible = true;
            lblHp.Text = HP.ToString();
        }

        public override string ToString()
        {
            return String.Format($"{Name}");
        }

    }
}
