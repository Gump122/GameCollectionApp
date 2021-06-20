using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Windows;

namespace GameCollectionApp.ljw
{
    public class Program
    {
        TcpListener tcl;
        TcpClient tcc;
        Game game;
        Thread thread;
        bool next;
        Command command;

        public Program()
        {
            game = new Game();
        }

        public void setCommand(int x,int y)
        {
            command.x = x;
            command.y = y;
        }

        public bool createGame(int port)
        {
            tcl = new TcpListener(port);
            tcl.Start();
            int count=5;
            while(--count>=0)
            {
                Thread.Sleep(1000);
                if(tcl.Pending())
                {
                    tcc = tcl.AcceptTcpClient();
                    thread = new Thread(createGameRun);
                    thread.Start();
                    return true;
                }
            }
            return false;
        }

        private void createGameRun()
        {
            next = true;
            while(true)
            {
                byte[] buf = new byte[8];
                if (next)
                {
                    switch (game.set(command.x, command.y, piece.black))
                    {
                        case 0:
                            for (int i = 0; i < 4; i++)
                            {
                                buf[i] = (byte)(command.x >> 8 * i);
                                buf[i + 4] = (byte)(command.y >> 8 * i);
                            }
                            tcc.Client.Send(buf);
                            next = !next;
                            break;
                        case 1:
                            for (int i = 0; i < 4; i++)
                            {
                                buf[i] = (byte)(command.x >> i);
                                buf[i + 4] = (byte)(command.y >> i);
                            }
                            tcc.Client.Send(buf);
                            MessageBox.Show("black win");
                            return;
                        case 2:
                            for (int i = 0; i < 4; i++)
                            {
                                buf[i] = (byte)(command.x >> i);
                                buf[i + 4] = (byte)(command.y >> i);
                            }
                            tcc.Client.Send(buf);
                            MessageBox.Show("white win");
                            return;
                        case -1:
                            continue;
                    }
                }
                else
                {
                    if (tcc.Client.Receive(buf) != 8)
                        continue;
                    command.x = 0;
                    command.y = 0;
                    for (int i=0;i<4;i++)
                    {
                        //buf[i] = (byte)(command.x >> i);
                        //buf[i + 4] = (byte)(command.y >> i);
                        command.x += buf[i] << 8 * i;
                        command.y += buf[i + 4] << 8 * i;
                    }
                    switch (game.set(command.x, command.y, piece.white))
                    {
                        case 0:
                            next = !next;
                            continue;
                        case -1:
                            MessageBox.Show("recieve error");
                            return;
                        case 1:
                            MessageBox.Show("black win");
                            return;
                        case 2:
                            MessageBox.Show("white win");
                            return;
                    }

                }
            }
        }

        public bool joinGame(string host,int port)
        {
            tcc = new TcpClient(host, port);
            //tcc.Connect(host, port);
            int count = 0;
            while(++count>5)
            {
                Thread.Sleep(1000);
                if(tcc.Connected)
                {
                    thread = new Thread(joinGameRun);
                    thread.Start();
                    return true;
                }
            }
            return false;
        }

        private void joinGameRun()
        {
            next = false;
            while(true)
            {
                byte[] buf=new byte[8];
                if(next)
                {
                    switch (game.set(command.x, command.y, piece.white))
                    {
                        case 0:
                            for (int i = 0; i < 4; i++)
                            {
                                buf[i] = (byte)(command.x >> 8 * i);
                                buf[i + 4] = (byte)(command.y >> 8 * i);
                            }
                            tcc.Client.Send(buf);
                            next = !next;
                            break;
                        case 1:
                            for (int i = 0; i < 4; i++)
                            {
                                buf[i] = (byte)(command.x >> i);
                                buf[i + 4] = (byte)(command.y >> i);
                            }
                            tcc.Client.Send(buf);
                            MessageBox.Show("black win");
                            return;
                        case 2:
                            for (int i = 0; i < 4; i++)
                            {
                                buf[i] = (byte)(command.x >> i);
                                buf[i + 4] = (byte)(command.y >> i);
                            }
                            tcc.Client.Send(buf);
                            MessageBox.Show("white win");
                            return;
                        case -1:
                            continue;
                    }
                }
                else
                {
                    if (tcc.Client.Receive(buf) != 8)
                        continue;
                    command.x = 0;
                    command.y = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        //buf[i] = (byte)(command.x >> i);
                        //buf[i + 4] = (byte)(command.y >> i);
                        command.x += buf[i] << 8 * i;
                        command.y += buf[i + 4] << 8 * i;
                    }
                    switch (game.set(command.x, command.y, piece.black))
                    {
                        case 0:
                            next = !next;
                            continue;
                        case -1:
                            MessageBox.Show("recieve error");
                            return;
                        case 1:
                            MessageBox.Show("black win");
                            return;
                        case 2:
                            MessageBox.Show("white win");
                            return;
                    }
                }
            }
        }

        public void over()
        {
            thread.Abort();
            thread = null;
        }

        public piece[,] getTable()
        {
            return game.getTable();
        }

        //采用管道所以不需要访问控制了
        //public bool controlAble()
        //{
        //    return next;
        //}

        ~Program()
        {
            if (thread != null)
                thread.Abort();
        }
    }

    struct Command
    {
        public int x;
        public int y;
        //public piece color;
    }

    public enum piece
    { empty,black,white}
    class Game
    {
        piece[,] table;
        int size;
        public static int defaultSize = 10;

        public Game(int n)
        {
            table = new piece[n, n];
            this.size = n;
        }
        public Game() : this(defaultSize) { }

        public int set(int x,int y,piece color)
        {
            if (table[x, y] != piece.empty)
                return -1;
            table[x, y] = color;
            return (int)judge5();  
        }

        public piece[,] getTable()
        {
            return table;
        }

        private piece judge5()
        {
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size;j++)
                {
                    if(table[i,j]!=piece.empty)
                    {
                        for(int k=0;k<8;k++)
                        {
                            if(line(k,i,j,table[i,j],1)>=5)
                            {
                                return table[i, j];
                            }
                        }
                    }
                }
            }

            return piece.empty;
        }

        private int line(int direct,int x,int y,piece color,int count)
        {
            switch(direct)
            {
                case 0:
                    y++;
                    break;
                case 1:
                    y++;
                    x++;
                    break;
                case 2:
                    x++;
                    break;
                case 3:
                    x++;
                    y--;
                    break;
                case 4:
                    y--;
                    break;
                case 5:
                    y--;
                    x--;
                    break;
                case 6:
                    x--;
                    break;
                case 7:
                    x--;
                    y++;
                    break;
            }

            if (x >= size || y >= size)
                return count;

            if(color == table[x, y])
            {
                count = line(direct, x, y, color, count);
                return ++count;
            }

            return count;
        }


    }
}
