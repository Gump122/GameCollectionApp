using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionApp.xc
{
  public partial class XcForm : Form
  {
    private Form parent;
    private Pyramid pyramid;
    private List<CardsPictureBox> cardsPictureBoxes;
    const int cardWidth = 108;
    const int cardHeight = 150;
    public XcForm(Form parent)
    {
      InitializeComponent();
      this.parent = parent;
      this.Text = "金字塔纸牌";
      pyramid = new Pyramid();
      List<Card> deck = pyramid.getCorrectCards();
      pyramid.startGame(deck,7,true);
      cardsPictureBoxes = new List<CardsPictureBox>();
      foreach (CardsPictureBox cd in cardsPictureBoxes)
      {
        cd.BringToFront();
      }
      DrawPyramid();
      BackgroundImage = Properties.Resources.background;
      scoreLabel.BackColor = Color.Transparent;
    }

    private void XcForm_Load(object sender, EventArgs e)
    {

    }

    public void showMenu()   //显示菜单
    {
      Panel menuPanel = new Panel(); //菜单面板
      menuPanel.Size = new Size(menuButton.Width, 4 * menuButton.Height);
      menuPanel.Location = new Point(menuButton.Location.X, 0 * menuButton.Height);
      menuPanel.BorderStyle = BorderStyle.Fixed3D;
      Controls.Add(menuPanel);
      menuPanel.BringToFront();

      //退出选项
      Button exitButton = new Button();
      exitButton.Size = new Size(menuButton.Width, menuButton.Height);
      exitButton.Location = new Point(menuPanel.Location.X, menuPanel.Location.Y);
      exitButton.Text = "退出游戏";
      exitButton.Click += new EventHandler((object s, EventArgs e) =>
      {
        parent.Show();
        Close();
      });
      Controls.Add(exitButton);
      exitButton.BringToFront();

      //提示选项
      Button reminderButton = new Button();
      reminderButton.Size = new Size(menuButton.Width, menuButton.Height);
      reminderButton.Location = new Point(menuPanel.Location.X, menuPanel.Location.Y + 1 * menuButton.Height);
      reminderButton.Text = "提示";
      //reminderButton.Click += new EventHandler((object s, EventArgs e) =>
      Controls.Add(reminderButton);
      reminderButton.BringToFront();

      //重新开始选项
      Button restartButton = new Button();
      restartButton.Size = new Size(menuButton.Width, menuButton.Height);
      restartButton.Location = new Point(menuPanel.Location.X, menuPanel.Location.Y + 2*menuButton.Height);
      restartButton.Text = "重新开始";
      //reminderButton.Click += new EventHandler((object s, EventArgs e) =>
      Controls.Add(restartButton);
      restartButton.BringToFront();

      //游戏规则选项
      Button ruleButton = new Button();
      ruleButton.Size = new Size(menuButton.Width, menuButton.Height);
      ruleButton.Location = new Point(menuPanel.Location.X, menuPanel.Location.Y + 3 * menuButton.Height);
      ruleButton.Text = "游戏规则";
      ruleButton.Click += new EventHandler((object s, EventArgs e) =>
      {
        MessageBox.Show("123");
      });
      Controls.Add(ruleButton);
      ruleButton.BringToFront();

      //返回游戏选项
      Button returnButton = new Button();
      returnButton.Size = new Size(menuButton.Width, menuButton.Height);
      returnButton.Location = new Point(menuPanel.Location.X, menuPanel.Location.Y + 4 * menuButton.Height);
      returnButton.Text = "返回游戏";
      returnButton.Click += new EventHandler((object s, EventArgs e) =>
      {
        Controls.Remove(menuPanel);
        Controls.Remove(reminderButton);
        Controls.Remove(restartButton);
        Controls.Remove(exitButton);
        Controls.Remove(ruleButton);
        Controls.Remove(returnButton);
      });
      Controls.Add(returnButton);
      returnButton.BringToFront();
    }

    public void DrawPyramid()
    {
      if (pyramid.getRowsNum() < 0) throw new Exception("金字塔行数小于零");

      int rowPoint = -30 /*menuButton.Height*/, colPoint = 0;
      for (int i = 0; i < pyramid.getRowsNum(); i++)
      {
        rowPoint += cardHeight / 3;
        for (int j = 0; j < pyramid.getRowWidth(i); j++)
        {
          if (i % 2 == 0) { colPoint = this.Width / 2 - cardWidth / 2 - (i / 2) * (cardWidth * 4 / 3) + j * (cardWidth * 4 / 3); }
          if (i % 2 == 1) { colPoint = this.Width / 2 - cardWidth * 4 / 3 * (i + 1) / 2 + cardWidth / 6 + j * cardWidth * 4 / 3; }

          CardsPictureBox cardspicture = new CardsPictureBox(i, j);
          cardspicture.Size = new Size(cardWidth, cardHeight);
          cardspicture.Load("CardsPicture\\" + pyramid.getCard(i, j).transString() + ".png");
          cardspicture.SizeMode = PictureBoxSizeMode.StretchImage; //使图像拉伸或收缩，以便适合 PictureBox
          cardspicture.Location = new Point(colPoint, rowPoint);          
          cardspicture.Click += new EventHandler(cardClick);
          cardsPictureBoxes.Add(cardspicture);
          Controls.Add(cardspicture);
          cardspicture.BringToFront();
        }
      }
    }

    public void cardClick(object sender, EventArgs e)
    {

    }

    private void menuButton_Click(object sender, EventArgs e)
    {
      showMenu();
    }

    private void scoreLabel_Click(object sender, EventArgs e)
    {

    }

        //dk_0607_1420
        private void XcForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
