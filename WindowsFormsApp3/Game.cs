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
        //Player1SET
        public CardSet[] player1Set = new CardSet[4];
        public CardSet[] Player1Set
        {
            get { return player1Set; }
        }

        //Player2Set
        public CardSet[] player2Set = new CardSet[4];
        public CardSet[] Player2Set
        {
            get { return player2Set; }
        }

        //заменить плаер на воркардплеер
        public WarCardPlayer Player1 { get; }// думаю, больше двух игроков не будет, можно их делать не списком, а двумя переменными
        public WarCardPlayer Player2 { get; }

        public CardSet Deck { get; }
        public WarCardPlayer ActivePlayer { get; set; }
        public CardSet[] ActivePlayerTable { get; set; }
        public WarCardPlayer firstPlayer { get; set; }
        public Action<Player> MarkActivePlayer;
        public Action<string> ShowMessage;

        public int Money { get; set; }//добавляем еще переменную, которая содержит инфу, стоимость на ход у игрока

        public Game(CardSet card1P1, CardSet card2P1, CardSet card3P1, CardSet card4P1, CardSet card1P2, CardSet card2P2, CardSet card3P2, CardSet card4P2, WarCardPlayer p1, WarCardPlayer p2)
        {
            //Set1
            player1Set[0] = card1P1;
            player1Set[1] = card2P1;
            player1Set[2] = card3P1;
            player1Set[3] = card4P1;
            //Set2
            player2Set[0] = card1P1;
            player2Set[1] = card2P1;
            player2Set[2] = card3P1;
            player2Set[3] = card4P1;
            //Player1
            Player1 = p1;
            //Player2
            Player2 = p2;

            //deck

            ActivePlayer = Player1;
            ActivePlayerTable = Player1Set;
            firstPlayer = Player1;
        }

        public void Move(WarCardPlayer mover, Card card, CardSet to) //тут мы еще получаем кардсет, куда он ходит, назовем его to
        {
            if (mover != ActivePlayer) return;

            if (mover.PlayerCards.Cards.IndexOf(card) == -1) return;

            //проверяем, ему ли принадлежит кардсет, куда он хочет походить
            if (ActivePlayerTable.FirstOrDefault(cs => cs == to) == null) return;



            if (Money < card.Money) return;// проверяем хватает ли стоимости на ход этой картой
            if (to.Cards.Count > 0) to.Cards.Clear();//тут проверяем, пустой ли кадсет или нет. Если нет. Ту карту, которая там, сбрасываем (удаляем)
            to.Add(mover.PlayerCards.Pull(card));
            if (Money == 0)
            {
                NextMove();

            }


            MarkActivePlayer(ActivePlayer);

            Refresh();
        }

        private void NextMove()
        {
            if (ActivePlayer == firstPlayer)
            {
                ActivePlayer = NextPlayer(ActivePlayer);
                MarkActivePlayer(ActivePlayer);
                Money = 2;
            }
            else
            {
                Beat();// если исчерпана стоимость активного игрока, меняем активного, обозначаем активного
            }

            firstPlayer = firstPlayer == Player1 ? Player2 : Player1;
            ActivePlayer = firstPlayer;
            Refresh();
        }

        public void Refresh()
        {
            foreach (var item in Player1Set)//введешь кучу кардсетов, логика усложнится
            {
                item.Show();
            }
            foreach (var item in Player2Set)//введешь кучу кардсетов, логика усложнится
            {
                item.Show();
            }
        }

        private WarCardPlayer NextPlayer(WarCardPlayer player)
        {
            //тут можно упростить логику, если игроков будет только двое
            if (player == Player1) return Player2;

            return Player1;
        }
        
        
        public void Beat()
        {
            for (int i = 0; i < player1Set.Length; i++)
            {
                Shot(Player1Set[i], Player2Set[i], Player2);
                Shot(Player2Set[i], Player1Set[i], Player1);
                if (Player1Set[i].Cards[0].HP <= 0) Player1Set[i].Cards.Clear();
                if (Player2Set[i].Cards[0].HP <= 0) Player2Set[i].Cards.Clear();
            }




            //подготовить сл. ход.
        }

        private void Shot(CardSet active, CardSet passive, WarCardPlayer passivePlayer)
        {
            if (active.Cards.Count == 0) return;
            
            if (passive.Cards.Count == 0)//проверить побитого игрока
            {
                passivePlayer.HP -= active.Cards[0].Damage;//снять хп
            }

            passive.Cards[0].HP -= active.Cards[0].Damage;//проверить побитые карты
        }

        public void Deal()
        {
            Deck.Mix();
            foreach (var item in Player1Set)
            {
                item.Add(Deck.Deal(6));
            }
            foreach (var item in Player2Set)
            {
                item.Add(Deck.Deal(6));
            }
            Refresh();
        }
        public void GameOver()
        {
            if (Player1.HP==0)
            {
                ShowMessage("Player2 win");
            }
            if (Player2.HP == 0)
            {
                ShowMessage("Player1 win");
            }
        }

    }
}