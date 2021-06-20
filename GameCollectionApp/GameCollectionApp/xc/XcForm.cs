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
    public Button cutButton;
    private List<CardsPictureBox> cardsPictureBoxes;
    private CardsPictureBox tempCard = null;
    private List<CardsPictureBox> Pile;

    const int cardWidth = 80;
    const int cardHeight = 120;
    public XcForm(Form parent)
    {
      InitializeComponent();
      this.parent = parent;
      this.MaximizeBox = false;
      this.Size = new Size(1200,800);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "金字塔纸牌";
      this.Controls.Add(menuButton);
      this.Controls.Add(scoreLabel);
      this.menuButton.Location = new Point(0, 0);
      this.menuButton.Size = new Size(90, 40);
      this.scoreLabel.Location = new Point(this.Width - 2*this.scoreLabel.Width , menuButton.Location.Y+20);

      pyramid = new Pyramid();
      List<Card> deck = pyramid.getCorrectCards();
      pyramid.startGame(deck,7,true,2);
      cardsPictureBoxes = new List<CardsPictureBox>();
      Pile = new List<CardsPictureBox>();
      makePileDomain();
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
      reminderButton.Click += new EventHandler((object s, EventArgs e) => {
        List<CardsPictureBox> listCards = new List<CardsPictureBox>();
        List<(int, int)> tempList = new List<(int, int)>();
        tempList = pyramid.getTopCards();
        foreach (CardsPictureBox cd in cardsPictureBoxes)
        {
          foreach ((int, int) point in tempList)
          {
            if (point.Item1 == cd.getRowIndex() && point.Item2 == cd.getColIndex())
              listCards.Add(cd);
          }
        }

        for (int i = 0; i < listCards.Count; i++)
        {
          for (int j = i; j < listCards.Count; j++)
          {
            if (listCards[i].getRowIndex() != -1 && listCards[j].getRowIndex() != -1) //全在金字塔中
            {
              if (pyramid.getCard(listCards[i].getRowIndex(), listCards[i].getColIndex()).getValue() == 13 || pyramid.getCard(listCards[i].getRowIndex(), listCards[i].getColIndex()).getValue() + pyramid.getCard(listCards[j].getRowIndex(), listCards[j].getColIndex()).getValue() == 13)
              {
                if (tempCard != null)
                  tempCard.BorderStyle = BorderStyle.None;
                listCards[i].BorderStyle = BorderStyle.Fixed3D;
                listCards[j].BorderStyle = BorderStyle.Fixed3D;
                MessageBox.Show("已将一对牌框出！");

                return;
              }
            }
            else if (listCards[i].getRowIndex() != -1)  //一张在金字塔中
            {
              if (pyramid.getCard(listCards[i].getRowIndex(), listCards[i].getColIndex()).getValue() == 13)
              {
                if (tempCard != null)
                  tempCard.BorderStyle = BorderStyle.None;
                listCards[i].BorderStyle = BorderStyle.Fixed3D;
                MessageBox.Show("已经牌框出");

                return;
              }
              else if (pyramid.getCardInPile(listCards[j].getColIndex()).getValue() == 13)
              {
                if (tempCard != null)
                  tempCard.BorderStyle = BorderStyle.None;
                listCards[j].BorderStyle = BorderStyle.Fixed3D;
                MessageBox.Show("已经牌框出");

                return;
              }
              else if (pyramid.getCard(listCards[i].getRowIndex(), listCards[i].getColIndex()).getValue() + pyramid.getCardInPile(listCards[j].getColIndex()).getValue() == 13)
              {
                if (tempCard != null)
                  tempCard.BorderStyle = BorderStyle.None;
                listCards[i].BorderStyle = BorderStyle.Fixed3D;
                listCards[j].BorderStyle = BorderStyle.Fixed3D;
                MessageBox.Show("已将一对牌框出！");

                return;
              }
            }
            else if (listCards[j].getRowIndex() != -1)
            {
              if (pyramid.getCard(listCards[j].getRowIndex(), listCards[j].getColIndex()).getValue() == 13)
              {
                if (tempCard != null)
                  tempCard.BorderStyle = BorderStyle.None;
                listCards[j].BorderStyle = BorderStyle.Fixed3D;
                MessageBox.Show("已经牌框出");

                return;
              }
              else if (pyramid.getCardInPile(listCards[i].getColIndex()).getValue() == 13)
              {
                if (tempCard != null)
                  tempCard.BorderStyle = BorderStyle.None;
                listCards[i].BorderStyle = BorderStyle.Fixed3D;
                MessageBox.Show("已经牌框出");

                return;
              }
              else if (pyramid.getCard(listCards[j].getRowIndex(), listCards[j].getColIndex()).getValue() + pyramid.getCardInPile(listCards[i].getColIndex()).getValue() == 13)
              {
                if (tempCard != null)
                  tempCard.BorderStyle = BorderStyle.None;
                listCards[i].BorderStyle = BorderStyle.Fixed3D;
                listCards[j].BorderStyle = BorderStyle.Fixed3D;
                MessageBox.Show("已将一对牌框出！");

                return;
              }
            }
            else //在牌堆中
            {
              if (pyramid.getCardInPile(listCards[i].getColIndex()).getValue() + pyramid.getCardInPile(listCards[j].getColIndex()).getValue() == 13)
              {
                if (tempCard != null)
                  tempCard.BorderStyle = BorderStyle.None;
                listCards[i].BorderStyle = BorderStyle.Fixed3D;
                listCards[j].BorderStyle = BorderStyle.Fixed3D;
                MessageBox.Show("已将一对牌框出！");

                return;
              }
            }
          }
        }

        if (pyramid.getShuffleCount() < 2) { MessageBox.Show("请切牌或重新发牌"); }
        else MessageBox.Show("游戏已无法再进行下去了！");
      });
      Controls.Add(reminderButton);
      reminderButton.BringToFront();

      //重新开始选项
      Button restartButton = new Button();
      restartButton.Size = new Size(menuButton.Width, menuButton.Height);
      restartButton.Location = new Point(menuPanel.Location.X, menuPanel.Location.Y + 2*menuButton.Height);
      restartButton.Text = "重新开始";
      restartButton.Click += new EventHandler((object s, EventArgs e) => {
        Controls.Clear(); XcForm f = new XcForm(parent); this.Close(); f.Show();
      });
      Controls.Add(restartButton);
      restartButton.BringToFront();

      //游戏规则选项
      Button ruleButton = new Button();
      ruleButton.Size = new Size(menuButton.Width, menuButton.Height);
      ruleButton.Location = new Point(menuPanel.Location.X, menuPanel.Location.Y + 3 * menuButton.Height);
      ruleButton.Text = "游戏规则";
      ruleButton.Click += new EventHandler((object s, EventArgs e) =>
      {
        MessageBox.Show("不被任何牌压住的两张牌之和等于13，就可以匹配消除，K可以直接消除；\n一副扑克牌被分为金字塔（28张）和发牌区（24张）两部分；\n发牌区和金字塔，发牌区和发牌区的牌可以进行匹配；\n发牌区的牌一共可以刷新两次，每次刷新匹配掉的牌不会复原；\n每消除一张牌得10分，消除完金字塔所有的牌即为胜利");
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

    public void makePileDomain()
    {
      if (pyramid.getNumOfPile() < 0) throw new Exception("参数设置不正确");
      cutButton = new Button();

      int rowPoint = this.Width/2-cardWidth*7/4;
      int colPoint = this.Width / 2 - cardWidth * 7 / 4;
      Panel panel = new Panel();
      panel.Size = new Size(cardWidth * 7 / 2, cardHeight * 3 / 2);
      panel.Location = new Point(rowPoint,colPoint);
      panel.BorderStyle = BorderStyle.Fixed3D;
      Controls.Add(panel);
      panel.BringToFront();

      cutButton.Text = "切牌";
      cutButton.Size = new Size(cardWidth / 2, cardWidth / 2);
      cutButton.Location = new Point(colPoint + cardWidth * 3 / 2, rowPoint + cardHeight * 3 / 4 - cardWidth / 2);
      cutButton.Click += new EventHandler(cut_clk);

      Controls.Add(cutButton);
      cutButton.BringToFront();

      rowPoint += cardHeight / 4;
      colPoint += cardWidth / 4;
      for (int i = 0; i < pyramid.getNumOfPile(); i++)
      {
        CardsPictureBox cardpicture = new CardsPictureBox(-1, i);
        cardpicture.Size = new Size(cardWidth, cardHeight);
        if (pyramid.getCardInPile(i) != null)
          cardpicture.Load("CardsPicture\\" + pyramid.getCardInPile(i).transString() + ".png");
        else cardpicture.BorderStyle = BorderStyle.Fixed3D;
        cardpicture.SizeMode = PictureBoxSizeMode.StretchImage;
        cardpicture.Location = new Point(colPoint, rowPoint);
        cardsPictureBoxes.Add(cardpicture);
        cardpicture.Click += new EventHandler(cardClick);
        Pile.Add(cardpicture);
        Controls.Add(cardpicture);
        cardpicture.BringToFront();
        colPoint += cardWidth * 2;
      }
    }
    public void loadImageInPile(int index)
    {
      CardsPictureBox cd = Pile[index];
      if (pyramid.getCardInPile(index) != null)
      {
        if (cd.Image == null)
          cd.BorderStyle = BorderStyle.None;
        cd.Load("CardsPicture\\" + pyramid.getCardInPile(index).transString() + ".png");
      }
      else
      {
        cd.Image = null;
        cd.BorderStyle = BorderStyle.Fixed3D;
      }

    }
    public void cut_clk(object sender, EventArgs e)
    {
      pyramid.transCardsInPile();
      for (int i = 0; i < pyramid.getNumOfPile(); i++)
      {
        loadImageInPile(i);
      }

      if (tempCard != null)
      {
        if (tempCard.getRowIndex() == -1)
        {
          tempCard.BorderStyle = BorderStyle.None;
          tempCard = null;

        }
      }
      if (pyramid.heapCount() == 0 && pyramid.getCardInPile(0) == null)
      {
        cutButton.Text = "重新发牌";
        cutButton.Click -= new EventHandler(cut_clk);
        cutButton.Click += new EventHandler(pileShuffle_clk);
      }
    }

    public void pileShuffle_clk(object sender, EventArgs e)
    {
      if (pyramid.isGameOver())
      {
        pyramid.changeToGameOver();
        MessageBox.Show("游戏已经结束");
        return;
      }

      if (pyramid.getShuffleCount() < 2)
      {
        try
        {
          pyramid.shufflePileCards();
        }
        catch (Exception err)
        {
          System.IO.StringReader sr = new System.IO.StringReader(err.ToString());
          MessageBox.Show(sr.ReadLine());
        }
        for (int i = 0; i < pyramid.getNumOfPile(); i++)
          loadImageInPile(i);
        pyramid.addShuffleCount();
        cutButton.Text = "切牌";
        cutButton.Click -= new EventHandler(pileShuffle_clk);
        cutButton.Click += new EventHandler(cut_clk);
      }
      else
      {
        MessageBox.Show("您的洗牌机会已用尽");
        pyramid.addShuffleCount();
      }

    }

    public void cardClick(object sender, EventArgs e)
    {
      CardsPictureBox cd = (CardsPictureBox)sender;
      if (pyramid.isGameOver())
      {
        pyramid.changeToGameOver();
        MessageBox.Show("游戏已经结束");
        return;
      }
      if (cd.getRowIndex() == -1 && pyramid.getCardInPile(cd.getColIndex()) == null)
      {
        MessageBox.Show("这里什么都没有哦");
        return;
      }
      if (tempCard == null)
      {
        if (cd.getRowIndex() != -1)
        {
          if (pyramid.getCard(cd.getRowIndex(), cd.getColIndex()).getValue() == 13)
          {
            try
            {
              pyramid.removeOneCard(cd.getRowIndex(), cd.getColIndex());
              cardsPictureBoxes.Remove(cd);
              Controls.Remove(cd);
              cardsPictureBoxes.Remove(cd);
            }
            catch (Exception err)
            {
              System.IO.StringReader sr = new System.IO.StringReader(err.ToString());
              MessageBox.Show(sr.ReadLine());
            }
          }
          else
          {
            cd.BorderStyle = BorderStyle.Fixed3D;
            tempCard = cd;
          }
        }
        else
        {
          if (pyramid.getCardInPile(cd.getColIndex()).getValue() == 13)
          {
            try
            {
              pyramid.removeOneCardInPile(cd.getColIndex());
              loadImageInPile(cd.getColIndex());
            }
            catch (Exception err)
            {
              System.IO.StringReader sr = new System.IO.StringReader(err.ToString());
              MessageBox.Show(sr.ReadLine());
            }
          }
          else
          {
            cd.BorderStyle = BorderStyle.Fixed3D;
            tempCard = cd;
          }
        }
      }
      else if (tempCard == cd)  //两次点击取消点击状态
      {
        cd.BorderStyle = BorderStyle.None;
        tempCard = null;
      }
      else
      {
        if (cd.getRowIndex() == -1 && tempCard.getRowIndex() == -1)
        {
          if (pyramid.getCardInPile(cd.getColIndex()).getValue() + pyramid.getCardInPile(tempCard.getColIndex()).getValue() == 13)
          {
            try
            {
              pyramid.removeTwoCardsInPile(cd.getColIndex(), tempCard.getColIndex());
              cd.BorderStyle = BorderStyle.None;
              tempCard.BorderStyle = BorderStyle.None;
              loadImageInPile(cd.getColIndex());
              loadImageInPile(tempCard.getColIndex());
              tempCard = null;
            }
            catch (Exception err)
            {
              System.IO.StringReader sr = new System.IO.StringReader(err.ToString());
              MessageBox.Show(sr.ReadLine());
            }
          }
          else
          {
            MessageBox.Show("这两张牌的和不是13");
          }
        }
        else if (cd.getRowIndex() == -1)
        {
          try
          {
            pyramid.removeTwoCardsWithPile(cd.getColIndex(), tempCard.getRowIndex(), tempCard.getColIndex());
            Controls.Remove(tempCard);
            cardsPictureBoxes.Remove(tempCard);
            cd.BorderStyle = BorderStyle.None;
            loadImageInPile(cd.getColIndex());
            tempCard = null;
          }
          catch (Exception err)
          {
            System.IO.StringReader sr = new System.IO.StringReader(err.ToString());
            MessageBox.Show(sr.ReadLine());
          }
        }
        else if (tempCard.getRowIndex() == -1)
        {
          try
          {
            pyramid.removeTwoCardsWithPile(tempCard.getColIndex(), cd.getRowIndex(), cd.getColIndex());
            Controls.Remove(cd);
            cardsPictureBoxes.Remove(cd);
            tempCard.BorderStyle = BorderStyle.None;
            loadImageInPile(tempCard.getColIndex());
            tempCard = null;
          }
          catch (Exception err)
          {
            System.IO.StringReader sr = new System.IO.StringReader(err.ToString());
            MessageBox.Show(sr.ReadLine());
          }
        }
        else
        {
          try
          {
            pyramid.removeTwoCards(cd.getRowIndex(), cd.getColIndex(), tempCard.getRowIndex(), tempCard.getColIndex());
            Controls.Remove(tempCard);
            Controls.Remove(cd);
            cardsPictureBoxes.Remove(tempCard);
            cardsPictureBoxes.Remove(cd);
            tempCard = null;
          }
          catch (Exception err)
          {
            System.IO.StringReader sr = new System.IO.StringReader(err.ToString());
            MessageBox.Show(sr.ReadLine());
          }
        }

      }
      loadScoreData();

      if (pyramid.heapCount() == 0 && pyramid.getCardInPile(0) == null)
      {
        cutButton.Text = "重新发牌";
        cutButton.Click -= new EventHandler(cut_clk);
        cutButton.Click += new EventHandler(pileShuffle_clk);

      }
    }

    private void loadScoreData()
    {
      scoreLabel.Text = "得分:" + pyramid.getScore().ToString();
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
