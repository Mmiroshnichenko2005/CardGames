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
        public CardSet TableP1 { get; }
        public CardSet TableP2 { get; }
        
        public List<Player> Players { get; }// думаю, больше двух игроков не будет, можно их делать не списком, а двумя переменными
        public CardSet Deck { get; }
        public Player ActivePlayer { get; set; }
        public Action<Player> MarkActivePlayer;
        public Action<string> ShowMessage;

        //добавляем еще переменную, которая содержит инфу, стоимость на ход у игрока

        public Game(CardSet tableP1,CardSet tableP2, CardSet deck, params Player[] players)
        {
            TableP1 = tableP1;
            TableP2 = tableP2;
            Players = new List<Player>(players);
            Deck = deck;
            ActivePlayer = players[0];
        }

        public void Move(Player mover, Card card) //тут мы еще получаем кардсет, куда он ходит, назовем его to
        {
            if (mover != ActivePlayer) return;

            if (mover.PlayerCards.Cards.IndexOf(card) == -1) return;

            //проверяем, ему ли принадлежит кардсет, куда он хочет походить
            
            if(mover== ActivePlayer)//это уже проверили, ни к чему
            {
                // проверяем хватает ли стоимости на ход этой картой
                //тут проверяем, пустой ли кадсет или нет. Если нет. Ту карту, которая там, сбрасываем (удаляем)
                // после этого добавляем карту в кадсет to   TableP1.Add(mover.PlayerCards.Pull(card));
                // если исчерпана стоимость активного игрока, меняем активного, обозначаем активного
            }
            if (mover == new Player("P2")) //другая логика. Активен тот, кто ходит. Неактивный не ходит. Это не надо
            {
                TableP2.Add(mover.PlayerCards.Pull(card));
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
