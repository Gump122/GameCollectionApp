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
  }
  
  
}
