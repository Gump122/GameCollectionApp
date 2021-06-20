using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionApp.dk
{

    public delegate void sign();

    class Program
    {
        public sign fresh;
        Thread thread;

        Game game;
        Computer ai;

        bool controlable;
        int actionType;//0 run 1-3 chi 4 pen 5 gan
        int actionValue;
        bool actioned;
        bool[] locks;

        const int sleepTime = 500;

        public Program()
        {
            game = new Game();
            ai = new Computer();
            locks = new bool[13];
        }

        public void init(sign s)
        {
            fresh = s;
            game.init();
            actioned = false;
            controlable = false;
        }

        private void run()
        {
            while(true)
            {
                actionType = -1;
                fresh();
                Thread.Sleep(sleepTime);

                if (game.getRemainNum() == 0)
                {
                    MessageBox.Show("流局");
                    break;
                }

                //正常出牌
                if (game.getNext()==3)
                {
                    askAction(0);
                    game.run(actionValue);
                }
                else
                {
                    game.run(ai.run(game.getCards(game.getNext()), game.getBufCard()));
                }

                if (true)
                {
                    int hu = game.checkHu();
                    if (hu > 0)
                    {
                        string msg = "";
                        if (hu == 3)
                            msg += "玩家自摸";
                        if (hu == 4)
                            msg += "电脑自摸";
                        if (hu == 1)
                            msg += "玩家胡";
                        if (hu == 2)
                        {
                            msg += "电脑胡";
                            if (game.getNext() == 0)
                                msg = "玩家点炮";
                        }

                        fresh();
                        MessageBox.Show(msg);
                        

                        break;
                    }
                }

                //碰
                bool pened=false;
                for (int n = 0; n < 4; n++) 
                {
                    int r = game.getNext() + n;
                    if(r>3)
                    {
                        r -= 3;
                    }
                    if(game.checkPen(r))
                    {
                        if(r==3)
                        {
                            for(int i=0;i<13;i++)
                            {
                                if (game.getCards()[i].equals(game.getCardsAbandon().Last()))
                                    locks[i] = true;
                            }
                            askAction(4);
                            relock();
                            if (actionValue != 0)
                            {
                                game.pen(r, actionValue - 1);
                                pened = true;
                                relock();
                                break;
                            }
                        }
                        else
                        {
                            int _r = ai.run(game.getCards(r), game.getCardsAbandon().Last());
                            if (_r != 14)
                            {
                                game.pen(r, _r - 1);
                                pened = true;
                                break;
                            }
                        }
                    }
                }

                if (pened)
                {
                    int hu = game.checkHu();
                    if (hu > 0)
                    {
                        string msg = "";
                        if (hu == 3)
                            msg += "玩家自摸";
                        if (hu == 4)
                            msg += "电脑自摸";
                        if (hu == 1)
                            msg += "玩家胡";
                        if (hu == 2)
                        {
                            msg += "电脑胡";
                            if (game.getNext() == 0)
                                msg = "玩家点炮";
                        }

                        fresh();
                        MessageBox.Show(msg);
                        

                        break;
                    }
                }


                //吃
                bool chied = false;
                for (int i = 0; i < 3; i++)
                {
                    if (game.checkChi(i + 1)) 
                    {
                        if (game.getNext() == 3)
                        {
                            Card c1 = game.getCardsAbandon().Last();
                            Card c2 = game.getCardsAbandon().Last();
                            switch (i)
                            {
                                case 0:
                                    c1.num += 1;
                                    c2.num += 2;
                                    break;
                                case 1:
                                    c1.num -= 1;
                                    c2.num += 1;
                                    break;
                                case 2:
                                    c1.num -= 1;
                                    c2.num -= 2;
                                    break;
                            }
                            for (int j = 0; j < 13; j++)
                            {
                                if (game.getCards()[j].equals(c1))
                                {
                                    locks[j] = true;
                                    c1.num = 0;
                                }
                                if (game.getCards()[j].equals(c2))
                                {
                                    locks[j] = true;
                                    c2.num = 0;
                                }
                            }
                            askAction(i + 1);
                            relock();
                            if (actionValue != 0) 
                            {
                                game.chi(actionValue - 1, i + 1);
                                chied = true;
                                relock();
                                break;
                            }
                        }
                        else
                        {
                            int r = ai.run(game.getCards(game.getNext()), game.getCardsAbandon().Last());
                            if (r!=14)
                            {
                                game.chi(r - 1, i + 1);
                                chied = true;
                                break;
                            }
                        }
                    }
                }

                if (chied)
                {
                    int hu = game.checkHu();
                    if (hu > 0)
                    {
                        string msg = "";
                        if (hu == 3)
                            msg += "玩家自摸";
                        if (hu == 4)
                            msg += "电脑自摸";
                        if (hu == 1)
                            msg += "玩家胡";
                        if (hu == 2)
                        {
                            msg += "电脑胡";
                            if (game.getNext() == 0)
                                msg = "玩家点炮";
                        }

                        fresh();
                        MessageBox.Show(msg);

                        break;
                    }
                }
            }
        }

        public bool[] getLocks()
        {
            return locks;
        }

        public bool[] getShowCards()
        {
            bool[] r = new bool[13];
            for(int i=0;i<13;i++)
            {
                r[i] = game.getCards()[i].show;
            }
            return r;
        }

        private void relock()
        {
            for(int i=0;i<locks.Length;i++)
            {
                locks[i] = false;
                if (game.getCards()[i].show)
                    locks[i] = true;
            }
        }

        public int getRemainCardsNum()
        {
            return game.getRemainNum();
        }

        private void askAction(int type)
        {
            actionType = type;
            fresh();
            controlable = true;
            while (!actioned)
            {

            }
            controlable = false;
            actioned = false;
            actionType = 0;
            fresh();
        }

        public void setAction(int value)
        {
            if (!controlable)
                return;
            actionValue = value;
            actioned = true;
        }

        public void setAction(int value,int type)
        {
            if (!controlable)
                return;
            actionValue = value;
            actionType = type;
            actioned = true;
        }

        public Card[] getPlayerCards()
        {
            return game.getCards(3);
        }

        public Card getBufCard()
        {
            return game.getBufCard();
        }

        public int getActionType()
        {
            return actionType;
        }

        public List<Card> getCardsAbandon()
        {
            return game.getCardsAbandon();
        }

        public void start()
        {
            thread = new Thread(this.run);
            thread.Start();
        }

        public void over()
        {
            thread.Abort();
        }

        ~Program()
        {
            if (thread != null)
                over();
        }
    }

    class Game
    {
        Card[] playerCards;
        Card[,] computersCards;
        List<Card> cardsAbandon;
        Card[] cardsRemain;
        int cardsRemainNum;
        Card bufCard;
        int next;

        public Game()
        {
            playerCards = new Card[13];
            computersCards = new Card[3,13];
            cardsAbandon = new List<Card>();
            cardsRemain = new Card[102];
        }

        public void init()
        {
            Random r = new Random((int)DateTime.Now.ToBinary());
            bool[] table = new bool[102];
            for (int i = 0; i < 102; i++)
                table[i] = false;
            for (int n = 0; n < 102; n++) 
            {
                int i = r.Next(101);
                while(table[i])
                {
                    if (i == 101)
                        i = 0;
                    else
                        i++;
                }
                table[i] = true;
                i = i % 34;
                cardsRemain[n] = itoc(i);
            }
            cardsRemainNum = 102;
            for(int i=0;i<13;i++)
            {
                playerCards[i] = cardsRemain[--cardsRemainNum];
                for (int j = 0; j < 3; j++)
                    computersCards[j, i] = cardsRemain[--cardsRemainNum];
            }
            next = r.Next(3);
            bufCard = cardsRemain[--cardsRemainNum];
            sort(playerCards);
        }

        //0-33
        private Card itoc(int i)
        {
            Card c;
            c.color = (Card.Color)(i / 9);
            c.num = (ushort)(i % 9 + 1);
            c.show = false;
            return c;
        }

        //0-33
        private int ctoi(Card c)
        {
            int i = 0;
            i += ((int)c.color)*9;
            i += (int)c.num-1;
            return i;
        }

        public int getNext()
        {
            return next;
        }

        public bool getRemain()
        {
            return cardsRemainNum == 0;
        }

        public int getRemainNum()
        {
            return cardsRemainNum;
        }
        public Card getBufCard()
        {
            return new Card(bufCard);
        }

        public List<Card> getCardsAbandon()
        {
            return cardsAbandon;
        }

        public Card[] getCards(int n)
        {
            Card[] cards = new Card[13];
            if(n==3)
            {
                for (int i = 0; i < 13; i++)
                    cards[i] = playerCards[i];
                return cards;
            }
            for (int i = 0; i < 13; i++)
                cards[i] = computersCards[n,i];
            return cards;
        }

        public Card[] getCards()
        {
            return getCards(3);
        }

        //1-14
        public void run(int i)
        {
            if (i == 14)
            {
                cardsAbandon.Add(bufCard);
                next++;
                if (next == 4)
                    next = 0;
                bufCard = cardsRemain[--cardsRemainNum];
                return;
            }
            //player=3
            if (next == 3) 
            {
                cardsAbandon.Add(playerCards[i-1]);
                playerCards[i-1] = bufCard;
                next = 0;
                bufCard = cardsRemain[--cardsRemainNum];
                sort(playerCards);
                return;
            }
            //computer=0-2
            cardsAbandon.Add(computersCards[next, i-1]);
            computersCards[next, i-1] = bufCard;
            next++;
            bufCard = cardsRemain[--cardsRemainNum];
            
        }

        public bool checkChi(int type)
        {
            if (cardsAbandon.Last().color == Card.Color.z)
                return false;
            Card[] cards = getCards(next);
            bool r1 = false;
            bool r2 = false;
            Card c1 = cardsAbandon.Last();
            Card c2 = cardsAbandon.Last();
            switch (type)
            {
                case 1:
                    c1.num += 1;
                    c2.num += 2;
                    break;
                case 2:
                    c1.num -= 1;
                    c2.num += 1;
                    break;
                case 3:
                    c1.num -= 1;
                    c2.num -= 2;
                    break;
            }
            foreach(Card card in cards)
            {
                if (card.show)
                    continue;
                if (card.equals(c1))
                    r1 = true;
                if (card.equals(c2))
                    r2 = true;
            }
            return r1 && r2;
        }

        public void chi(int i,int type)
        {
            Card buf = cardsAbandon.Last();
            cardsAbandon.RemoveAt(cardsAbandon.Count() - 1);
            if (next==3)
            {
                cardsAbandon.Add(playerCards[i]);
                playerCards[i] = buf;
                next = 0;

                Card c1 = buf;
                Card c2 = buf;
                switch (type)
                {
                    case 1:
                        c1.num += 1;
                        c2.num += 2;
                        break;
                    case 2:
                        c1.num -= 1;
                        c2.num += 1;
                        break;
                    case 3:
                        c1.num -= 1;
                        c2.num -= 2;
                        break;
                }

                playerCards[i].show = true;
                for(int j=0;j<13;j++)
                {
                    if (playerCards[j].show)
                        continue;
                    if (playerCards[j].equals(c1))
                    {
                        playerCards[j].show = true;
                        c1.num = 0;
                    }
                    if(playerCards[j].equals(c2))
                    {
                        playerCards[j].show = true;
                        c2.num = 0;
                    }
                }

                sort(playerCards);
            }
            else
            {
                cardsAbandon.Add(computersCards[next, i]);
                computersCards[next, i] = buf;
                next += 1;
            }
        }

        public bool checkPen(int n)
        {
            int count=0;
            if(n==3)
            {
                foreach(Card card in playerCards)
                {
                    if (card.show)
                        continue;
                    if (cardsAbandon.Last().equals(card))
                        count++;
                }
            }
            else
            {
                for(int i=0;i<13;i++)
                {
                    if (cardsAbandon.Last().equals(computersCards[n, i]))
                        count++;
                }
            }
            if (count == 2)
                return true;
            return false;
        }

        public void pen(int n,int i)
        {
            Card buf = cardsAbandon.Last();
            cardsAbandon.RemoveAt(cardsAbandon.Count()-1);
            if (n == 3)
            {
                cardsAbandon.Add(playerCards[i]);
                playerCards[i] = buf;
                for(int j=0;j<13;j++)
                {
                    if (playerCards[j].show)
                        continue;
                    if (playerCards[j].equals(buf))
                        playerCards[j].show = true;
                }
                sort(playerCards);
                next = 0;
            }
            else
            {
                cardsAbandon.Add(computersCards[n,i]);
                computersCards[n, i] = buf;
                for (int j = 0; j < 13; j++)
                {
                    if (computersCards[n, j].equals(buf)) 
                        computersCards[n, j].show = true;
                }
                next = n + 1;
            }
        }

        //public bool checkGan(int n)
        //{

        //}

        //public void gan(int n)
        //{

        //}

        public int checkHu()
        {
            Card[] cards = new Card[14];
            cards[13] = cardsAbandon.Last();

            for (int i = 0; i < 13; i++) 
            {
                cards[i] = playerCards[i];
                if (_checkHu(cards))
                    return 1;
            }

            for (int n = 0; n < 3; n++)
            {
                for (int i = 0; i < 13; i++)
                {
                    cards[i] = computersCards[n, i];
                    if (_checkHu(cards))
                        return 2;
                }
            }

            cards[13] = bufCard;

            if (next == 3) 
            {
                for (int i = 0; i < 13; i++)
                {
                    cards[i] = playerCards[i];
                    if (_checkHu(cards))
                        return 3;
                }
            }
            else 
            {
                for (int i = 0; i < 13; i++)
                {
                    cards[i] = computersCards[next, i];
                    if (_checkHu(cards))
                        return 4;
                }
            }

            return 0;
        }

        public bool _checkHu(Card[] cards)
        {
            Card[] buf = new Card[14];

            for (int i=0;i<14-1;i++)
            {
                for (int j = 0; j < 14; j++)
                    buf[j] = cards[j];

                if (buf[i].equals(buf[i+1]))
                {
                    buf[i].show = true;
                    buf[i + 1].show = true;

                    if (recursionCheck(buf))
                        return true;
                }
            }

            return false;
        }

        private bool recursionCheck(Card[] cards)
        {
            bool r = true;
            foreach (Card card in cards)
                r &= card.show;
            if (r)
                return true;

            Card[] buf = new Card[14];
            for (int i = 0; i < 14; i++)
                buf[i] = cards[i];

            sort(buf);

            if(buf[0].equals(buf[1])&& buf[0].equals(buf[2]))
            {
                buf[0].show = true;
                buf[1].show = true;
                buf[2].show = true;
                if (recursionCheck(buf))
                    return true;
            }

            Card c1 = buf[0];
            c1.num += 1;
            Card c2 = buf[0];
            c2.num += 2;
            for(int i=0;i<14;i++)
            {
                if (buf[i].show)
                    break;
                if(buf[i].equals(c1))
                {
                    buf[i].show = true;
                    c1.num = 0;
                }
                if (buf[i].equals(c2))
                {
                    buf[i].show = true;
                    c2.num = 0;
                }
            }
            if (c1.num == c2.num)
                return recursionCheck(buf);

            return false;
        }

        private void sort(Card[] cards)
        {
            Card buf;
            for(int i=0;i<cards.Length;i++)
            {
                for(int j=0;j<cards.Length-i-1;j++)
                {
                    if(_compare(cards[j],cards[j+1]))
                    {
                        buf = cards[j];
                        cards[j] = cards[j + 1];
                        cards[j + 1] = buf;
                    }
                }
            }
        }

        //return c1<c2 坨，索，万，字（东南西北中发白）
        private bool compare(Card c1,Card c2)
        {
            if (c1.show != c2.show)
            {
                if (c1.show)
                    return false;
                if (c2.show)
                    return true;
            }
            return ctoi(c1) < ctoi(c2);
        }
        //return c1>c2 坨，索，万，字（东南西北中发白）
        private bool _compare(Card c1, Card c2)
        {
            if(c1.show!=c2.show)
            {
                if (c1.show)
                    return true;
                if (c2.show)
                    return false;
            }
            return ctoi(c1) > ctoi(c2);
        }
    }

    public struct Card
    {
        public enum Color
        {
            t, s, w, z
        }
        public Color color;
        public ushort num;
        public bool show;

        public Card(Card card)
        {
            this.color = card.color;
            this.num = card.num;
            this.show = card.show;
        }

        public bool equals(Card card)
        {
            return color == card.color && num == card.num;
        }
    }

    class Computer
    {
        //待补
        public int run(Card[] cards,Card bufCard)
        {
            return 14;
        }
    }
}
