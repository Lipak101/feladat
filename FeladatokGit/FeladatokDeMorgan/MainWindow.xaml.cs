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

namespace FeladatokDeMorgan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Feladat f = new Feladat(Convert.ToInt32(A.Text), Convert.ToInt32(B.Text));
            first.Content += f.ElsoAzonossag().ToString();
            second.Content += f.MasodikAzonossag().ToString();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Feladat f = new Feladat(Convert.ToInt32(A.Text), Convert.ToInt32(B.Text));
            first.Content = f.ElsoAzonossag().ToString();
            second.Content = f.MasodikAzonossag().ToString();
        }
    }
}
