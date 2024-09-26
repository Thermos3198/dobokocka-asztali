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

namespace kp_orai
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            hatter.MouseUp += Hatter_MouseUp;

        }

        private void Hatter_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Random r = new Random();
            int rszam = r.Next(1, 7);
            szam.Text = rszam.ToString();
        }
    }
}
