using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Game
    {
        //Кардсетов дожно быть по количеству мест, куда карты можно положить, то есть всего 8. Подумай, как два массива или что-то такое
        public CardSet[] player1Set = new CardSet[4];
        public CardSet[] Player1Set
        {
            get { return player1Set; }
        }


        public CardSet[] Player2Set = new CardSet[4];
        public CardSet Card1P2 { get; }
        public CardSet Card2P2 { get; }
        public CardSet Card3P2 { get; }
        public CardSet Card4P2 { get; }
        //заменить плаер на воркардплеер
        public Player Player1 { get; }// думаю, больше двух игроков не будет, можно их делать не списком, а двумя переменными
        public Player Player2 { get; }

        public CardSet Deck { get; }
        public Player ActivePlayer { get; set; }
        public CardSet[] ActiveCardSet { get; set; }
        public Action<Player> MarkActivePlayer;
        public Action<string> ShowMessage;

        public int Money { get; set; }//добавляем еще переменную, которая содержит инфу, стоимость на ход у игрока

        public Game(CardSet tableP1, CardSet tableP2, CardSet deck, params Player[] players)
        {
            player1Set[0] = tableP2;

            TableP1 = tableP1;
            TableP2 = tableP2;
            Players = new List<Player>(players);
            Deck = deck;
            ActivePlayer = Player1;
            ActiveCardSet = Player1Set;
        }

        public void Move(Player mover, Card card, CardSet to) //тут мы еще получаем кардсет, куда он ходит, назовем его to
        {
            if (mover != ActivePlayer) return;

            if (mover.PlayerCards.Cards.IndexOf(card) == -1) return;

            //проверяем, ему ли принадлежит кардсет, куда он хочет походить
            if (ActiveCardSet.FirstOrDefault(cs => cs == to) == null) return;

            if (mover == ActivePlayer)//это уже проверили, ни к чему
            {

                // проверяем хватает ли стоимости на ход этой картой
                //тут проверяем, пустой ли кадсет или нет. Если нет. Ту карту, которая там, сбрасываем (удаляем)
                // после этого добавляем карту в кадсет to   TableP1.Add(mover.PlayerCards.Pull(card));
                if (ActivePlayer)// если исчерпана стоимость активного игрока, меняем активного, обозначаем активного
            }

            ActivePlayer = NextPlayer(ActivePlayer);
            MarkActivePlayer(ActivePlayer);
            Refresh();
        }


        public void Refresh()
        {
            foreach (var item in Players)//введешь кучу кардсетов, логика усложнится
            {
                item.PlayerCards.Show();
            }
            TableP1.Show();
            TableP2.Show();
        }

        private Player NextPlayer(Player player)
        {
            //тут можно упростить логику, если игроков будет только двое
            if (player == Players[Players.Count - 1]) return Players[0];

            return Players[Players.IndexOf(player) + 1];
        }

        private Player PreviousPlayer(Player player)
        {
            if (player == Players[0]) return Players[Players.Count - 1];

            return Players[Players.IndexOf(player) - 1];
        }

        //бой надо прописать
        // тут все относительно просто, думаю допрешь
        // если коротко, то проверяешь соответственные кардсеты, забираешь хп, удаляешь игроков, жизни которых закончены


        //еще нужен метод для того, чтоб отдать ход. В нем ты меняешь активного и 
        //всю оставшуюся стоимость забираешь картами
        //везде, где меняешь активного игрока нужно, по-моему, добавлять карту активному

        public void Beat()
        {
            for (int i = 0; i < player1Set.Length; i++)
            {
                Shot(player1Set[i], Player2Set[i], Player2);
                Shot(player2Set[i], Player1Set[i], Player1);
            }
            //проверить побитые карты
            //проверить побитого игрока
           //рефреш
           //подготовить сл. ход.
        }

        private void Shot(CardSet active, CardSet passive, Player passivePlayer)
        {
            if (active.Cards.Count == 0) return;

            if (passive.Cards.Count == 0) { }//снять хп

            passive.Cards[0].HP -= active.Cards[0].Damage;

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