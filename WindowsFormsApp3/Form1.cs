using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Card activeCard;
        Game game;
        WarCardPlayer mover;
        CardSet to;
        public Form1()
        {
            InitializeComponent();
        }

        


        private void ShowMessage(string message)
        {
            lblMessage.Text = message;
        }

        private void MarkPlayer(Player activePlayer)
        {
            Player[] Players = { game.Player1, game.Player2 };
            foreach (var player in Players)
            {
                if (player == activePlayer)
                    foreach (var card in player.PlayerCards.Cards)
                    {
                        GraphicCard graphicCard = (GraphicCard)card;
                        graphicCard.Opened = true;
                    }
                else
                    foreach (var card in player.PlayerCards.Cards)
                    {
                        GraphicCard graphicCard = (GraphicCard)card;
                        graphicCard.Opened = false;
                    }

            }
            game.Refresh();

        }



        private void SetActiveCard(PictureBox pictureBox)
        {
            Player[] Players = { game.Player1, game.Player2 };
            foreach (var player in Players)
            {
                foreach (var card in player.PlayerCards.Cards)
                {
                    if (((GraphicCard)card).Pb == pictureBox)
                    {
                        if (card == activeCard)
                        {
                            activeCard = null;
                            pictureBox.Top -= 10;
                            mover = null;
                        }
                        else
                        {
                            activeCard = card;
                            pictureBox.Top += 10;
                            mover = (WarCardPlayer)player;
                        }
                        CheckReady();
                        return;
                    }
                }
            }
        }

        private void CheckReady()
        {
            if (activeCard != null && to != null && mover != null)
                game.Move(mover, activeCard, to);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            game = new Game(new GraphicCardSet(Card1P1),
                new GraphicCardSet(Card2P1),
                new GraphicCardSet(Card3P1),
                new GraphicCardSet(Card4P1),
                new GraphicCardSet(Card1P2),
                new GraphicCardSet(Card2P2),
                new GraphicCardSet(Card3P2),
                new GraphicCardSet(Card4P2),
               new WarCardPlayer("P1", new GraphicCardSet(pnlPlayer2),25),
               new WarCardPlayer("P2", new GraphicCardSet(pnlPlayer1),25),
               new GraphicCardSet(new Panel(), CardSetType.File));

            foreach (var card in game.Deck.Cards)
            {
                PictureBox cardPictureBox = ((GraphicCard)card).Pb;
                cardPictureBox.MouseClick += CardPictureBox_MouseClick;
            }

            game.ShowMessage = ShowMessage;
            game.MarkActivePlayer = MarkPlayer;

            game.Deal();
        }

        private void CardPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (e.Button == MouseButtons.Left)
                SetActiveCard(pictureBox);
            else if (e.Button == MouseButtons.Right)
            {
                SetCardSet(pictureBox);
            }
        }

        private void SetCardSet(PictureBox pictureBox)
        {
            List<CardSet> allSets = new List<CardSet>();
            allSets.AddRange(game.Player1Set);
            allSets.AddRange(game.Player2Set);

            to = allSets.FirstOrDefault(cs => ((GraphicCard)cs.Cards[0]).Pb == pictureBox);
            CheckReady();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlDeck_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Card4P1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
