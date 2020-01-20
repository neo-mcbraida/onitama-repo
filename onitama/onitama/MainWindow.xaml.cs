using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace onitama
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public List<pawn> white = new List<pawn>();
        public List<pawn> black = new List<pawn>();
        public pawn pselected;
        public Card cselected;
        public List<Card> crds = new List<Card>();
        public List<Button> crdplaceholer = new List<Button>();
        public List<List<Button>> placeholders = new List<List<Button>>();
        public List<Button> possiblemoves = new List<Button>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            crdplaceholer.Add(crd1); crdplaceholer.Add(crd2); crdplaceholer.Add(crd3); crdplaceholer.Add(crd4); crdplaceholer.Add(crd5);
            placeholders.Add(new List<Button> { p1, p2, p3, p4, p5 });
            placeholders.Add(new List<Button> { p6, p7, p8, p9, p10 });
            placeholders.Add(new List<Button> { p11, p12, p13, p14, p15 });
            placeholders.Add(new List<Button> { p16, p17, p18, p19, p20 });
            placeholders.Add(new List<Button> { p21, p22, p23, p24, p25 });
            white.Add(new pawn(p1, w1, new List<int>() { 0, 0})); white.Add(new pawn(p2, w2, new List<int>() { 1, 0 })); white.Add(new pawn(p3, w3, new List<int>() { 2, 0 })); white.Add(new pawn(p4, w4, new List<int>() { 3, 0 })); white.Add(new pawn(p5, w5, new List<int>() { 4, 0 }));
            white.Add(new pawn(p21, b1, new List<int>() { 0, 4 })); white.Add(new pawn(p22, b2, new List<int>() { 1, 4 })); white.Add(new pawn(p23, b3, new List<int>() {2, 4 })); white.Add(new pawn(p24, b4, new List<int>() { 3, 4 })); white.Add(new pawn(p25, b5, new List<int>() { 4, 4 }));
            Card.Gen(crdplaceholer, crds);
           // p19.Click += Button_Click;
        }

        private void Card_Click(object sender, RoutedEventArgs e)
        {

            //pawn.Findindex(pselected, placeholders);
            //pselected.positions.Clear();
            //foreach (List<int> c in crd.vector)
            //{
            //    int x = pselected.index[0];
            //    int y = pselected.index[1];
            //    int x2 = c[0];
            //    int y2 = c[1];

            //    try
            //    {
            //        pselected.positions.Add(placeholders[x + x2][y + y2]);
            //        Canvas.SetZIndex(placeholders[x + x2][y + y2], 2);
            //        //    placeholders[x + x2][y + y2].Click += v;
            //        // placeholders[x + x2][y + y2].set
            //    }
            //    catch { }
            //}
        }

        private void Pawn_Click(object sender, RoutedEventArgs e)
        {

        //    pawn.Findindex(pwn, placeholders);
        //    pwn.positions.Clear();
        //    foreach (List<int> c in crd.vector)
        //    {
        //        int x = pwn.index[0];
        //        int y = pwn.index[1];
        //        int x2 = c[0];
        //        int y2 = c[1];

        //        try
        //        {
        //            pwn.positions.Add(placeholders[x + x2][y + y2]);
        //            Canvas.SetZIndex(placeholders[x + x2][y + y2], 2);
        //            //    placeholders[x + x2][y + y2].Click += v;
        //            // placeholders[x + x2][y + y2].set
        //        }
        //        catch { }
        //    }
        }

        private void move_Click(object sender, RoutedEventArgs e)
        {
            Card.Getmoves(cselected, pselected, placeholders);
        }
    }
}
