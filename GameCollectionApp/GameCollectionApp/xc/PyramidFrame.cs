using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionApp.xc
{
  class PyramidFrame
  {
    private int rows=7;
    private List<Card[]> pyramid;

    public PyramidFrame(int r)
    {
      this.rows = r;
      this.pyramid = new List<Card[]>(rows);
    }

    public int getRows() { return this.rows; }

    public int getWidth(int row) {
      if (row >= 0 && row < rows) return row + 1;
      else throw new Exception("所选金字塔行数不合法");
    }
    public Card getCard(int row,int col)
    {
      if (row < rows && col < getWidth(row))
        return pyramid[row][col];
      else throw new Exception("所选牌越界");
    }
    public List<Card> initPyramidWithCards(List<Card> cards)    //用一副52张的牌堆初始化金字塔，并返回剩下的牌，用于加入到牌堆中。
    {
      for (int i = 0; i < rows; i++)
      {
        Card[] cardLine = new Card[getWidth(i)];
        for (int j = 0; j < getWidth(i); j++)
        {
          cardLine[j] = cards.First();
          cards.RemoveAt(0);
        }
        pyramid.Add(cardLine);
      }
      return cards;
    }

    public bool IsCardValueK(int row, int col)  //判断某张卡牌是否为K
    {
      Card card = getCard(row, col);
      if (card.getValue() == 13) return true;
      else return false;
    }
    public bool isOneTopCard(int row, int col)
    {
      if (row < this.getRows() - 1)
      {
        Card card1 = getCard(row + 1, col);
        Card card2 = getCard(row + 1, col + 1);

        if (card1 != null || card2 != null) return false;

      }
      return true;
    }
    public bool areTwoTopCards(int row1, int col1, int row2, int col2)
    {
      return isOneTopCard(row1, col1) && isOneTopCard(row2, col2);
    }
    public bool isCardsSumValueK(int row1, int col1, int row2, int col2)    //判断两张卡牌的和是否为K
    {
      Card card1 = getCard(row1, col1);
      Card card2 = getCard(row2, col2);
      if (card1.getValue() + card2.getValue() == 13) return true;
      else return false;
    }

    public void hideCard(int row, int col)  //将一张卡片隐藏起来，即设为null
    {
      this.pyramid[row][col] = null;
    }
    public void hideTwoCards(int row1, int col1, int row2, int col2)    //将两张卡牌隐藏起来
    {
      hideCard(row1, col1);
      hideCard(row2, col2);
    }
  }
  
  
}
