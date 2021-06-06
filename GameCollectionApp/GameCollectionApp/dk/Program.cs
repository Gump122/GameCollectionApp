using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
                fresh();
                Thread.Sleep(500);

                if(game.getNext()==3)
                {

                }
                else
                {

                }

                for (int n = 0; n < 4; n++) 
                {
                    int r = game.getNext() + n;
                    if(r>3)
                    {
                        r -= 3;
                    }
                    if(game.checkPen(r))
                    {
                        if(n==3)
                        {
                            askAction(4);
                            if (actionValue != 0)
                            {
                                game.pen(n, actionValue);
                                break;
                            }
                        }
                        else
                        {
                            r = ai.run(game.getCards(n), game.getBufCard());
                            if (r != 15)
                            {
                                game.pen(n, r);
                                break;
                            }
                        }
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    if (game.checkChi(i + 1)) 
                    {
                        if (game.getNext() == 3)
                        {
                            askAction(i + 1);
                            if (actionValue != 0) 
                            {
                                game.chi(actionValue,i + 1);
                                break;
                            }
                        }
                        else
                        {
                            int r = ai.run(game.getCards(game.getNext()), game.getBufCard());
                            if (r!=15)
                            {
                                game.chi(r, i + 1);
                                break;
                            }
                        }
                    }
                }
            }
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
            playerCards = new Card[14];
            computersCards = new Card[3,14];
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
            for(int i=0;i<14;i++)
            {
                playerCards[i] = cardsRemain[--cardsRemainNum];
                for (int j = 0; j < 3; j++)
                    computersCards[j, i] = cardsRemain[--cardsRemainNum];
            }
            next = r.Next(3);
            bufCard = cardsRemain[--cardsRemainNum];
        }

        //0-33
        private Card itoc(int i)
        {
            Card c;
            c.color = (Card.Color)(i / 4);
            c.num = (ushort)(i % 9 + 1);
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

        public Card getBufCard()
        {
            return new Card(bufCard);
        }

        public Card[] getCards(int n)
        {
            Card[] cards = new Card[14];
            if(n==3)
            {
                for (int i = 0; i < 14; i++)
                    cards[i] = playerCards[i];
                return cards;
            }
            for (int i = 0; i < 14; i++)
                cards[i] = computersCards[n,i];
            return cards;
        }

        public Card[] getCards()
        {
            return getCards(next);
        }

        //1-15
        public void run(int i)
        {
            if (i == 15)
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
                cardsAbandon.Add(playerCards[i]);
                playerCards[i] = bufCard;
                next = 0;
                bufCard = cardsRemain[--cardsRemainNum];
                return;
            }
            //computer=0-2
            cardsAbandon.Add(computersCards[next, i]);
            computersCards[next, i] = bufCard;
            next++;
            bufCard = cardsRemain[--cardsRemainNum];
        }

        public bool checkChi(int type)
        {

        }

        public void chi(int i,int type)
        {

        }

        public bool checkPen(int n)
        {

        }

        public void pen(int n,int i)
        {

        }

        //public bool checkGan(int n)
        //{

        //}

        //public void gan(int n)
        //{

        //}

        public int checkHu()
        {
            Card[] cards = new Card[15];
            cards[14] = bufCard;
            if (next==3)
            {
                for (int i = 0; i < 14; i++) 
                {
                    cards[i] = playerCards[i];
                }
            }
            else
            {
                for (int i = 0; i < 14; i++)
                {
                    cards[i] = computersCards[next,i];
                }
            }
            return _checkHu(cards);
        }

        private int _checkHu(Card[] cards)
        {
            sort(cards);
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
            return ctoi(c1) < ctoi(c2);
        }
        //return c1>c2 坨，索，万，字（东南西北中发白）
        private bool _compare(Card c1, Card c2)
        {
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

        public Card(Card card)
        {
            this.color = card.color;
            this.num = card.num;
        }
    }

    class Computer
    {
        public int run(Card[] cards,Card bufCard)
        {
            return 15;
        }
    }
}
