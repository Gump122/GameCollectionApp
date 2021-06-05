using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionApp.xc
{
  enum Suit
  {
    dimond,
    club,
    spade,
    heart
  }
  class Card
  {
    private int value;
    private Suit suit;

    public Card(int value, Suit suit)
    {
      this.value = value;
      this.suit = suit;
    }

    public int getValue() { return this.value; }
    public string getSuit() { return suit.ToString(); }
    public string transString() { return getSuit().ToString() + getValue().ToString(); }
  }
}
