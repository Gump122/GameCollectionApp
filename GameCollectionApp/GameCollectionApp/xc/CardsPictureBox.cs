using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionApp.xc
{
  partial class CardsPictureBox: PictureBox
  {
    private int rowIndex;
    private int colIndex;

    public CardsPictureBox(int row, int col) : base()
    {
      rowIndex = row;
      colIndex = col;
    }
    public int getRowIndex()
    {
      return rowIndex;
    }
    public int getColIndex() { return colIndex; }
  }
}
