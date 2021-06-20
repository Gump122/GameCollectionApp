using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionApp.dk
{
    public partial class DkForm : Form
    {
        private Form parent;

        Program program;

        const float abandonCardsAreaX = 300.0f;
        const float abandonCardsAreaY = 140.0f;

        public DkForm(Form parent)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//关闭跨进程调用控件报错捕获,不安全
            this.parent = parent;
        }

        private void DkForm_Load(object sender, EventArgs e)
        {
            program = new Program();
            program.init(this.fresh);
            program.start();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            program.over();
            parent.Show();
            Close();
        }

        private Button itob(int i)
        {
            switch(i)
            {
                case 1:
                    return card1;
                case 2:
                    return card2;
                case 3:
                    return card3;
                case 4:
                    return card4;
                case 5:
                    return card5;
                case 6:
                    return card6;
                case 7:
                    return card7;
                case 8:
                    return card8;
                case 9:
                    return card9;
                case 10:
                    return card10;
                case 11:
                    return card11;
                case 12:
                    return card12;
                case 13:
                    return card13;
                case 14:
                    return card14;
            }
            return null;
        }

        public void fresh()
        {
            card1.Image = ctoim(program.getPlayerCards()[0]);
            card2.Image = ctoim(program.getPlayerCards()[1]);
            card3.Image = ctoim(program.getPlayerCards()[2]);
            card4.Image = ctoim(program.getPlayerCards()[3]);
            card5.Image = ctoim(program.getPlayerCards()[4]);
            card6.Image = ctoim(program.getPlayerCards()[5]);
            card7.Image = ctoim(program.getPlayerCards()[6]);
            card8.Image = ctoim(program.getPlayerCards()[7]);
            card9.Image = ctoim(program.getPlayerCards()[8]);
            card10.Image = ctoim(program.getPlayerCards()[9]);
            card11.Image = ctoim(program.getPlayerCards()[10]);
            card12.Image = ctoim(program.getPlayerCards()[11]);
            card13.Image = ctoim(program.getPlayerCards()[12]);

            bool[] showCards = program.getShowCards();
            for (int i = 0; i < 13; i++)
            {
                if (showCards[i])
                    itob(i + 1).Location = new Point(itob(i + 1).Location.X, 778);
                else
                    itob(i + 1).Location = new Point(itob(i + 1).Location.X, 678);
            }

            for (int i = 0; i < program.getLocks().Length; i++)
            {
                if (program.getLocks()[i])
                    itob(i + 1).Enabled = false;
                else
                    itob(i + 1).Enabled = true;
            }

            if (program.getActionType() == 0)
            {
                card14.Image = ctoim(program.getBufCard());
                card14.Show();
            }
            else
            {
                card14.Image = null;
                card14.Hide();
            }

            if (program.getActionType() == 4) 
            {
                cancelPen.Show();
            }
            else
            {
                cancelPen.Hide();
            }

            if (program.getActionType() < 4 && program.getActionType() > 0) 
            {
                cancelChi.Show();
            }
            else
            {
                cancelChi.Hide();
            }

            RemainCardsTextBox.Text = "剩余：";
            RemainCardsTextBox.AppendText(Convert.ToString(program.getRemainCardsNum()));
            //Graphics g =this.CreateGraphics();
            Image buf = new Bitmap(1920,980);
            Graphics g = Graphics.FromImage(buf);
            float dx = 0;
            float dy = 0;
            int count = 0;
            foreach(Card card in program.getCardsAbandon())
            {
                g.DrawImage(ctoim(card),dx,dy,88,118);
                count++;
                if (count % 13 == 0)
                {
                    dy += 118;
                    dx = 0;
                }
                else
                    dx += 88;
            }
            g = this.CreateGraphics();
            g.DrawImage(buf,abandonCardsAreaX,abandonCardsAreaY);

        }

        private Image ctoim(Card card)
        {
            switch(card.color)
            {
                case Card.Color.t:
                    switch (card.num)
                    {
                        case 1:
                            return Properties.Resources._1t;
                        case 2:
                            return Properties.Resources._2t;
                        case 3:
                            return Properties.Resources._3t;
                        case 4:
                            return Properties.Resources._4t;
                        case 5:
                            return Properties.Resources._5t;
                        case 6:
                            return Properties.Resources._6t;
                        case 7:
                            return Properties.Resources._7t;
                        case 8:
                            return Properties.Resources._8t;
                        case 9:
                            return Properties.Resources._9t;
                    }
                    break;

                case Card.Color.s:
                    switch(card.num)
                    {
                        case 1:
                            return Properties.Resources._1s;
                        case 2:
                            return Properties.Resources._2s;
                        case 3:
                            return Properties.Resources._3s;
                        case 4:
                            return Properties.Resources._4s;
                        case 5:
                            return Properties.Resources._5s;
                        case 6:
                            return Properties.Resources._6s;
                        case 7:
                            return Properties.Resources._7s;
                        case 8:
                            return Properties.Resources._8s;
                        case 9:
                            return Properties.Resources._9s;
                    }
                    break;

                case Card.Color.w:
                    switch(card.num)
                    {
                        case 1:
                            return Properties.Resources._1w;
                        case 2:
                            return Properties.Resources._2w;
                        case 3:
                            return Properties.Resources._3w;
                        case 4:
                            return Properties.Resources._4w;
                        case 5:
                            return Properties.Resources._5w;
                        case 6:
                            return Properties.Resources._6w;
                        case 7:
                            return Properties.Resources._7w;
                        case 8:
                            return Properties.Resources._8w;
                        case 9:
                            return Properties.Resources._9w;
                    }
                    break;

                case Card.Color.z:
                    switch(card.num)
                    {
                        case 1:
                            return Properties.Resources.d;
                        case 2:
                            return Properties.Resources.n;
                        case 3:
                            return Properties.Resources.x;
                        case 4:
                            return Properties.Resources.b;
                        case 5:
                            return Properties.Resources.z;
                        case 6:
                            return Properties.Resources.f;
                        case 7:
                            return Properties.Resources.bb;
                    }
                    break;
            }
            return null;
        }

        private void card13_Click(object sender, EventArgs e)
        {
            program.setAction(13);
        }

        private void card12_Click(object sender, EventArgs e)
        {
            program.setAction(12);
        }

        private void card11_Click(object sender, EventArgs e)
        {
            program.setAction(11);
        }

        private void card10_Click(object sender, EventArgs e)
        {
            program.setAction(10);
        }

        private void card9_Click(object sender, EventArgs e)
        {
            program.setAction(9);
        }

        private void card8_Click(object sender, EventArgs e)
        {
            program.setAction(8);
        }

        private void card7_Click(object sender, EventArgs e)
        {
            program.setAction(7);
        }

        private void card6_Click(object sender, EventArgs e)
        {
            program.setAction(6);
        }

        private void card5_Click(object sender, EventArgs e)
        {
            program.setAction(5);
        }

        private void card4_Click(object sender, EventArgs e)
        {
            program.setAction(4);
        }

        private void card3_Click(object sender, EventArgs e)
        {
            program.setAction(3);
        }

        private void card2_Click(object sender, EventArgs e)
        {
            program.setAction(2);
        }

        private void card1_Click(object sender, EventArgs e)
        {
            program.setAction(1);
        }



        private void card14_Click(object sender, EventArgs e)
        {
            program.setAction(14);
        }

        private void DkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            program.over();
            parent.Show();
        }

        private void cancelPen_Click(object sender, EventArgs e)
        {
            program.setAction(0);
        }

        private void cancelChi_Click(object sender, EventArgs e)
        {
            program.setAction(0);
        }
    }
}
