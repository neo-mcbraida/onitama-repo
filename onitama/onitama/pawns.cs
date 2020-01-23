using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace onitama
{
    public class pawn
    {
        public Button pos { get; set; }
      //  public List<Button> positions { get; set; }
        public List<int> index { get; set; }
        public string Imgref { get; set; }
       // public Button piece { get; set; }
        public pawn(Button _pos, List<int> _index, string _imgref)
        {
            index = _index;
            pos = _pos;
            Imgref = _imgref;
            //   piece = _piece;
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
        public static void move(Button pselected, Button newpos)
        {
            dynamic z = pselected.DataContext;
            pawn r = z;
            string img = r.Imgref;
            newpos.DataContext = pselected.DataContext;
            newpos.Content = new Image
            {
                Source = new BitmapImage(new Uri(img, UriKind.RelativeOrAbsolute))
            };
            pselected.DataContext = null;
            pselected.Content = null;
        }


    }
}

