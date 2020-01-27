using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace onitama
{
    public class Selected
    {
        public List<Button> possible { get; set; }
        public pawn pwn { get; set; }
        public Card crd { get; set; }
        public bool player1 = true;
        public bool highlighted = false;

        public static void clearhighlight(List<List<Button>> pholders)
        {
            foreach (List<Button> i in pholders)
            {
                foreach (Button u in i)
                {
                    u.Background = Brushes.Transparent;
                }
            }
        }
        public void move(Button newpos, Button oldpos)
        {
            if (possible.Contains(newpos))
            {
                oldpos.Content = null;
                oldpos.DataContext = null;
                newpos.DataContext = pwn;
                newpos.Content = new Image
                {
                    Source = new BitmapImage(new Uri(pwn.Imgref, UriKind.RelativeOrAbsolute))
                };
                possible.Clear();
                pwn = null;
                crd = null;
                player1 = !player1; // reverses bool(incase i forget syntax..)
                highlighted = !highlighted; 
            }
        }
        public void highlight(List<List<Button>> pholders)
        {
            clearhighlight(pholders);
            if (pwn != null && crd != null)
            if (player1 == true)
            {
                foreach (List<int> v in crd.vector)
                {
                    try
                    {
                        int y = pwn.index[0] + v[0];
                        int x = pwn.index[1] + v[1];
                        if (pwn.pwntype == "wp" || pwn.pwntype == "wk" && pholders[y][x].DataContext == null)
                        {
                            pholders[y][x].Background = Brushes.DarkRed;
                            possible.Add(pholders[y][x]);
                        }
                    }
                    catch { }
                }
                highlighted = !highlighted;
            }
            else if (player1 == false)
            {
                foreach (List<int> v in crd.vector)
                {
                    try
                    {
                        int y = pwn.index[0] - v[0];
                        int x = pwn.index[1] - v[1];
                        if (pwn.pwntype == "bp" || pwn.pwntype == "bk" && pholders[y][x].DataContext == null)
                        {
                             pholders[y][x].Background = Brushes.DarkRed;
                             possible.Add(pholders[y][x]); 
                        }
                    }
                    catch { }
                }
                highlighted = !highlighted;
            }
        }

    }
}
