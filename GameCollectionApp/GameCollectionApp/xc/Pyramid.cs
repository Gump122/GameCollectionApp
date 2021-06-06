using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionApp.xc
{
  class Pyramid
  {
    private PyramidFrame frame;
    private List<Card> heap;    //非金字塔中的牌
    public void startGame(List<Card> deck,int numOfRows,bool shuffle)
    {
      List<Card> list = getInitDeck(deck, shuffle);
      frame = new PyramidFrame(numOfRows);
      this.heap = this.frame.initPyramidWithCards(list);
    }

    protected List<Card> getInitDeck(List<Card> deck, bool shuffle)
    {
      // 将deck复制一份
      List<Card> copyDeck = new List<Card>();
      foreach (Card card in deck) { copyDeck.Add(card); }

      // 选择是否洗牌
      if (shuffle) copyDeck = getRandomDeck(copyDeck);

      return copyDeck;
    }
    private List<Card> getRandomDeck(List<Card> myList)
    {
      Random ran = new Random();
      List<Card> newList = new List<Card>();
      int index = 0;
      Card card = new Card();
      for (int i = 0; i < myList.Count; i++)
      {

        index = ran.Next(0, myList.Count - 1);
        if (index != i)
        {
          card = myList[i];
          myList[i] = myList[index];
          myList[index] = card;
        }
      }
      return myList;
    }
    public /*static*/ List<Card> getCorrectCards()
    {
      List<Card> cards = new List<Card>();

      foreach (Suit suit in Enum.GetValues(typeof(Suit)))
      {
        for (int i = 1; i <= 13; i++)
        {
          cards.Add(new Card(suit, i));
        }
      }
      return cards;
    }
    public int getRowsNum()
    {
      return frame.getRows();
    }
    public int getRowWidth(int r)
    {
      return frame.getWidth(r);
    }
    public Card getCard(int row, int col)
    {
      return frame.getCard(row, col);
    }
  }
}
