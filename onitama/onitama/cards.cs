using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace onitama
{




    public class Card
    {


        public List<Card> cards = new List<Card>();

        public List<List<int>> vector { get; set; }
        public int current { get; set; }
        public int col { get; set; }
        public int selected { get; set; }
        public string imgref { get; set; }
        public Card(List<List<int>> _pos, int _current, int _col, int _selected, string _imgref)
        {
            vector = _pos;
            current = _current;
            col = _col;
            selected = _selected;
            imgref = _imgref;
        }

        public static void Gen(List<Button> crdplaceholer, List<Card> cards)
        {
            createcrds(cards);
            foreach (Button crd in crdplaceholer)
            {
                var random = new Random();
                int index = random.Next(cards.Count);
                crd.Content = new Image
                {
                    Source = new BitmapImage(new Uri(cards[index].imgref, UriKind.RelativeOrAbsolute)),
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Stretch = Stretch.Fill
                };
                crd.DataContext = cards[index];
                cards.RemoveAt(index);
            }
        }
        public static void Getmoves(Card crd, pawn pwn, List<List<Button>> placeholders/*, RoutedEventHandler v*/)
        {
            //pawn.Findindex(pwn, placeholders);
            //pwn.positions.Clear();
            //foreach (List<int> c in crd.vector)
            //{
            //    int x = pwn.index[0];
            //    int y = pwn.index[1];
            //    int x2 = c[0];
            //    int y2 = c[1];

            //    try
            //    {
            //        pwn.positions.Add(placeholders[x + x2][y + y2]);
            //        Canvas.SetZIndex(placeholders[x + x2][y + y2], 2);
            //        //    placeholders[x + x2][y + y2].Click += v;
            //        // placeholders[x + x2][y + y2].set
            //    }
            //    catch { }
            //}
        }

        // public List<Card> crds = new List<Card>()
        public static void createcrds(List<Card> crd)
        {

            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, -1 }, new List<int>() { 1, 1 }, new List<int>() { 0, 2 } }, 3, 1, 0, @"F:\schoolc#\onitama\onitama\assetts\bat.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, 0 }, new List<int>() { 1, 0 }, new List<int>() { 0, 1 } }, 3, 1, 0, @"F:\schoolc#\onitama\onitama\assetts\bear.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, -1 }, new List<int>() { -1, 1 }, new List<int>() { 1, 2 }, new List<int>() { -2, 1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\bison.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 1, 0 }, new List<int>() { 0, 1 }, new List<int>() { 0, -1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\cow.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 0, -2 }, new List<int>() { 0, 2 }, new List<int>() { 1, 0 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\crawler.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 0, -1 }, new List<int>() { 1, 1 }, new List<int>() { -1, 1 } }, 3, 1, 0, @"F:\schoolc#\onitama\onitama\assetts\duck.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 2, 0 }, new List<int>() { -1, 0 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\eel.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 1, 0 }, new List<int>() { -1, -1 }, new List<int>() { -1, 1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\lemur.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 0, -1 }, new List<int>() { 0, 1 }, new List<int>() { -1, 1 }, new List<int>() { 1, -1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\lion.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 0, -1 }, new List<int>() { 1, -1 }, new List<int>() { 0, 1 }, new List<int>() { 1, 1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\mole.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 1, 1 }, new List<int>() { -1, -1 }, new List<int>() { -1, 1 }, new List<int>() { 1, -1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\monkey.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 1, -1 }, new List<int>() { 1, 1 }, new List<int>() { -1, 0 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\penguin.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 1, -1 }, new List<int>() { -1, -1 }, new List<int>() { 0, 1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\pentapus.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 0, -1 }, new List<int>() { 1, 0 }, new List<int>() { -1, 0 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\pine.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, -1 }, new List<int>() { 0, -1 }, new List<int>() { 0, 1 }, new List<int>() { 1, 1 } }, 3, 1, 0, @"F:\schoolc#\onitama\onitama\assetts\shirshu.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 0, -2 }, new List<int>() { 1, -1 }, new List<int>() { -1, 1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\wasp.jpg"));
            
        }
    
    }
}
