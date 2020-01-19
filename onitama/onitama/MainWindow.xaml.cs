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
            Card.Gen(crdplaceholer, crds);
           // p19.Click += Button_Click;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

    }
}
