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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sum = 0;
        string newNr = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged()
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("1");
            newNr += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("2");
            newNr += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("3");
            newNr += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("4");
            newNr += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("5");
            newNr += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("6");
            newNr += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("7");
            newNr += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("8");
            newNr += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("9");
            newNr += "9";
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("0");
            newNr += "0";
        }

        private void Button_Click_M(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("-");
            sum = sum - Convert.ToInt32(newNr);
            newNr = "";
        }

        private void Button_Click_P(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("+");
            sum = sum + Convert.ToInt32(newNr);
            newNr = "";       
        }

        private void Button_Click_E(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("=");
            sum = sum + Convert.ToInt32(newNr);
            txtbox.AppendText(Convert.ToString(sum));
            newNr = Convert.ToString(sum);
            sum = 0;
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            txtbox.Clear();
            sum = 0;
            newNr = "";
        }
    }
}
