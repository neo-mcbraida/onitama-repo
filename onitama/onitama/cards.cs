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
                    //Source = new BitmapImage(new Uri("/Card_Assets/green_0_large.png", UriKind.RelativeOrAbsolute)),
                    Source = new BitmapImage(new Uri(cards[index].imgref, UriKind.RelativeOrAbsolute)),
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Stretch = Stretch.Fill,
                 //   Height = 116,
                 //   Width = 75
                };
                cards.RemoveAt(index);
            }
        }
        public void Getmoves(pawn pwn, List<List<Button>> placeholders)
        {
            pawn.Findindex(placeholders);
        }

        // public List<Card> crds = new List<Card>()
        public static void createcrds(List<Card> crd)
        {

            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, -1 }, new List<int>() { 1, 1 }, new List<int>() { 2, 0 } }, 3, 1, 0, @"F:\schoolc#\onitama\onitama\assetts\bat.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 0, -1 }, new List<int>() { 0, 1 }, new List<int>() { 1, 0 } }, 3, 1, 0, @"F:\schoolc#\onitama\onitama\assetts\bear.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, -1 }, new List<int>() { 1, -1 }, new List<int>() { 2, 1 }, new List<int>() { -2, 1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\bison.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 0, 1 }, new List<int>() { 1, 0 }, new List<int>() { -1, 0 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\cow.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -2, 0 }, new List<int>() { 2, 0 }, new List<int>() { 0, 1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\crawler.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, 0 }, new List<int>() { 1, 1 }, new List<int>() { 1, -1 } }, 3, 1, 0, @"F:\schoolc#\onitama\onitama\assetts\duck.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 0, 2 }, new List<int>() { 0, -1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\eel.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 0, 1 }, new List<int>() { -1, -1 }, new List<int>() { 1, -1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\lemur.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, 0 }, new List<int>() { 1, 0 }, new List<int>() { 1, 1 }, new List<int>() { -1, -1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\lion.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, 0 }, new List<int>() { -1, 1 }, new List<int>() { 1, 0 }, new List<int>() { 1, 1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\mole.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { 1, 1 }, new List<int>() { -1, -1 }, new List<int>() { -1, 1 }, new List<int>() { 1, -1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\monkey.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, 1 }, new List<int>() { 1, 1 }, new List<int>() { 0, -1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\penguin.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, 1 }, new List<int>() { -1, -1 }, new List<int>() { 1, 0 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\pentapus.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, 0 }, new List<int>() { 0, 1 }, new List<int>() { 0, -1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\pine.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -1, -1 }, new List<int>() { -1, 0 }, new List<int>() { 1, 0 }, new List<int>() { 1, 1 } }, 3, 1, 0, @"F:\schoolc#\onitama\onitama\assetts\shirshu.jpg"));
            crd.Add(new Card(new List<List<int>>() { new List<int>() { -2, 0 }, new List<int>() { -1, 1 }, new List<int>() { 1, -1 } }, 3, 0, 0, @"F:\schoolc#\onitama\onitama\assetts\wasp.jpg"));
            
        }
    
    }
}
