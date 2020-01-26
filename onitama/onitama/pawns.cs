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
        public List<int> index { get; set; }
        public string Imgref { get; set; }
        public string pwntype { get; set; }
        public pawn(List<int> _index, string _imgref, string _pwntype)
        {
            index = _index;
            Imgref = _imgref;
            pwntype = _pwntype;
        }



        //public void Findindex(List<List<Button>> positions)
        //{
        //    int u = 0;
        //    for (int i = 0; u < 0; i++)
        //    {
        //        for (int x = 0; u < 0 || x < 5; x++)
        //        {
        //            if (pos == positions[i][x])
        //            {

        //                //  pwn.index.AddRange(new List<int> { i, x });
        //            }
        //        }
        //    }
        //}
        // public void move(Button pselected, Button newpos)
        // {
        //  //   dynamic z = pselected.DataContext;
        ////     pawn r = z;
        //  //   string img = r.Imgref;
        //     newpos.DataContext = this;
        //     newpos.Content = new Image
        //     {
        //         Source = new BitmapImage(new Uri(Imgref, UriKind.RelativeOrAbsolute))
        //     };
        //     pselected.DataContext = null;
        //     pselected.Content = null;
        // }


    }
}

