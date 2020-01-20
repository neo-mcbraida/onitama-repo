using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace onitama
{
    public class pawn
    {
        public Button pos { get; set; }
      //  public List<Button> positions { get; set; }
        public List<int> index { get; set; }
        public Button piece { get; set; }
        public pawn(Button _pos, Button _piece, List<int> _index)
        {
            index = _index;
            pos = _pos;
            piece = _piece;
        }
        

        public static void Findindex(pawn pwn, List<List<Button>> positions)
        {
            int u = 0;
            for (int i = 0; u < 0; i++)
            {
                for (int x = 0; u < 0 || x < 5; x++)
                {
                    if (pwn.pos == positions[i][x])
                    {

                      //  pwn.index.AddRange(new List<int> { i, x });
                    }
                }
            }
        }
        public static void move()
        {

            //if (crd.pos[crd.selected] == piece.Margin)
            //{
            //    piece.Margin = crd.pos[crd.selected];
            //}
        }


    }
}

