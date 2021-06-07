using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionApp.xc
{
  enum Suit
  {
    diamond,
    club,
    spade,
    heart
  }
  class Card
  {
    private int value;
    private Suit suit;

    public Card(Suit suit,int value)
    {
      this.value = value;
      this.suit = suit;
    }

    public int getValue() { return this.value; }
    public string getSuit()
    {
      return suit.ToString();
    }
    public string transString()
    {
      return getSuit().ToString() + getValue().ToString();
    }

    public bool Isequal(object o)  //判断两张牌是否是同一张牌
    {
      if (this == o) return true;
      if (!(o is Card)) return false;
      else
      {
        Card c = (Card)o;
        return (this.getSuit() == c.getSuit() && this.getValue() == c.getValue());
      }
    }
    public Card()
    {
    }
  }

}
