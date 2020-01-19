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
        public List<int> index { get; set; }
        public int value { get; set; }
        public int col { get; set; }
        public Button piece { get; set; }

        public void Findindex(List<List<Button>> positions)
        {
            int u = 0;
            for (int i = 0; u < 0; i++)
            {
                for (int x = 0; u < 0 || x < 5; x++)
                {
                    if (pos == positions[i][x])
                    {
                        index.AddRange(new List<int> { i, x });
                    }
                }
            }
        }
        public void move(Card crd)
        {

            //if (crd.pos[crd.selected] == piece.Margin)
            //{
            //    piece.Margin = crd.pos[crd.selected];
            //}
        }


    }
}

