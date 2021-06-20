using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionApp.ljw
{
    public partial class GameForm : Form
    {
        Form parent;
        Program game;
        Thread thread;
        public GameForm(Form parent,Program game)
        {
            this.parent = parent;
            this.game = game;
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            thread = new Thread(fresh);
            thread.Start();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(thread!=null)    
                if(thread.IsAlive)
                    thread.Abort();
            parent.Show();
        }

        private void GameForm_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black);
            for (int y = (this.Size.Height - Game.defaultSize * 50 + 50) / 2;
                y <= (this.Size.Height + Game.defaultSize * 50 - 50) / 2; y += 50)
            {
                g.DrawLine(p, (this.Size.Width - Game.defaultSize * 50 + 50) / 2,
                    y, (this.Size.Width + Game.defaultSize * 50 - 50) / 2, y);
            }
            for (int x = (this.Size.Width - Game.defaultSize * 50 + 50) / 2;
                x <= (this.Size.Width + Game.defaultSize * 50 - 50) / 2; x += 50)
            {
                g.DrawLine(p, x, (this.Size.Height - Game.defaultSize * 50 + 50) / 2,
                    x, (this.Size.Height + Game.defaultSize * 50 - 50) / 2);
            }
        }

        private void GameForm_MouseClick(object sender, MouseEventArgs e)
        {
            int c_x = 0;
            int c_y = 0;
            for (int y = (this.Size.Height - Game.defaultSize * 50 + 50) / 2;
               y <= (this.Size.Height + Game.defaultSize * 50 - 50) / 2; y += 50)
            {
                if (e.Y - y <= 25)
                    break;
                c_y++;
            }
            for (int x = (this.Size.Width - Game.defaultSize * 50 + 50) / 2;
                x <= (this.Size.Width + Game.defaultSize * 50 - 50) / 2; x += 50)
            {
                if (e.X - x <= 25)
                    break;
                c_x++;
            }
            game.setCommand(c_x, c_y);

        }

        private void fresh()
        {
            Graphics g = this.CreateGraphics();
            SolidBrush sbb = new SolidBrush(Color.Black);
            SolidBrush sbw = new SolidBrush(Color.White);

            Thread.Sleep(500);

            while(true)
            {
                piece[,] table = game.getTable();
                for (int i = 0; i < Game.defaultSize; i++)
                {
                    for (int j = 0; j < Game.defaultSize; j++)
                    {
                        if (table[i, j] == piece.empty)
                            continue;
                        int x = (this.Size.Width - Game.defaultSize * 50 + 50) / 2 + 50 * i;
                        int y = (this.Size.Height - Game.defaultSize * 50 + 50) / 2 + 50 * j;

                        switch (table[i, j])
                        {
                            case piece.black:
                                g.FillEllipse(sbb, x - 10, y - 10, x + 10, y + 10);
                                break;
                            case piece.white:
                                g.FillEllipse(sbw, x - 10, y - 10, x + 10, y + 10);
                                break;
                        }

                    }
                }
            }

        }
    }
}
