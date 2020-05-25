﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Game
    {
        public CardSet TableP1 { get; }
        public CardSet TableP2 { get; }
        public List<Player> Players { get; }
        public CardSet Deck { get; }
        public Player ActivePlayer { get; set; }
        public Action<Player> MarkActivePlayer;
        public Action<string> ShowMessage;

        public Game(CardSet tableP1,CardSet tableP2, CardSet deck, params Player[] players)
        {
            TableP1 = tableP1;
            TableP2 = tableP2;
            Players = new List<Player>(players);
            Deck = deck;
            ActivePlayer = players[0];
        }

        public void Move(Player mover, Card card)
        {
            if (mover != ActivePlayer) return;

            if (mover.PlayerCards.Cards.IndexOf(card) == -1) return;
            
            if(mover== ActivePlayer)
            {
                TableP1.Add(mover.PlayerCards.Pull(card));
            }
            if (mover == new Player("P2"))
            {
                TableP2.Add(mover.PlayerCards.Pull(card));
            }
            ActivePlayer = NextPlayer(ActivePlayer);
            MarkActivePlayer(ActivePlayer);
            Refresh();
        }

        public void Refresh()
        {
            foreach (var item in Players)
            {
                item.PlayerCards.Show();
            }
            TableP1.Show();
            TableP2.Show();
        }

        private Player NextPlayer(Player player)
        {
            if (player == Players[Players.Count - 1]) return Players[0];

            return Players[Players.IndexOf(player) + 1];
        }

        private Player PreviousPlayer(Player player)
        {
            if (player == Players[0]) return Players[Players.Count - 1];

            return Players[Players.IndexOf(player) - 1];
        }

        public void Deal()
        {
            Deck.Mix();
            foreach (var item in Players)
            {
                item.PlayerCards.Add(Deck.Deal(4));
            }
            Refresh();
        }
        public void GameOver()
        {
            foreach (var item in Players)
            {
                if (item.PlayerCards.Cards.Count != 0)
                    ShowMessage(item.Name + "loose");
            }
        }

        public void HangUp()
        {
            TableP1.Cards.Clear();
            TableP2.Cards.Clear();
            Refresh();
        }
    }
}
