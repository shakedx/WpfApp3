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

namespace WpfApp3
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

        private void Button_Click1j(object sender, RoutedEventArgs e)
        {
            Result1.Text = new Linear().Action(double.Parse(a0j.Text), double.Parse(drj.Text), double.Parse(j.Text)).ToString();         
        }

        private void Button_Click2j(object sender, RoutedEventArgs e)
        {
            Result1.Text = new Exponential().Action(double.Parse(a0j.Text), double.Parse(drj.Text), double.Parse(j.Text)).ToString(); //mistake
        }

        private void Button_Click3sum(object sender, RoutedEventArgs e)
        {
            Result2.Text = new Linear().Sum(double.Parse(a0sum.Text), double.Parse(ansum.Text), double.Parse(nsum.Text)).ToString();         
        }

        private void Button_Click4sum(object sender, RoutedEventArgs e)
        {
            Result2.Text = new Exponential().Sum(double.Parse(a0sum.Text), double.Parse(ansum.Text), double.Parse(nsum.Text)).ToString();
        }
    }
}
