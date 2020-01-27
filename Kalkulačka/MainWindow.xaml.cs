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

namespace Kalkulačka
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<double> cisla = new List<double>();
        
        List<char> znamenka = new List<char>();
        
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void B_0_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += 0;
        }

        private void B_1_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += 1;
        }

        private void B_2_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += 2;
        }

        private void B_3_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += 3;
        }

        private void B_4_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += 4;
        }

        private void B_5_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += 5;
        }

        private void B_6_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += 6;
        }

        private void B_7_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += 7;
        }

        private void B_8_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += 8;
        }

        private void B_9_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += 9;
        }

        private void B_plus_Click(object sender, RoutedEventArgs e)
        {
            cisla.Add(Convert.ToDouble(textBlock.Text));
            znamenka.Add('+');
            textBlock_znamenka.Text = "+ ";
            textBlock.Text = "";
        }

        private void B_minus_Click(object sender, RoutedEventArgs e)
        {
            cisla.Add(Convert.ToDouble(textBlock.Text));
            znamenka.Add('-');
            textBlock_znamenka.Text = "- ";
            textBlock.Text = "";
        }

        private void B_multiply_Click(object sender, RoutedEventArgs e)
        {
            cisla.Add(Convert.ToDouble(textBlock.Text));
            znamenka.Add('*');
            textBlock_znamenka.Text = "* ";
            textBlock.Text = "";
        }

        private void B_slash_Click(object sender, RoutedEventArgs e)
        {
            cisla.Add(Convert.ToDouble(textBlock.Text));
            znamenka.Add('/');
            textBlock_znamenka.Text = "/ ";
            textBlock.Text = "";
        }

        private void B_equals_Click(object sender, RoutedEventArgs e)
        {
            cisla.Add(Convert.ToDouble(textBlock.Text));
            double x = cisla[0];

            for (int i = 0; i < znamenka.Count; i++)
            {
                
                if (znamenka[i] == '+')
                {
                    x += cisla[i + 1];
                }
                else if (znamenka[i] == '-')
                {
                    x -= cisla[i + 1];
                }
                else if (znamenka[i] == '*')
                {
                    x *= cisla[i + 1];
                }
                else if (znamenka[i] == '/')
                {
                    x /= cisla[i + 1];
                }
            }

            textBlock_znamenka.Text = "=";
            textBlock.Text = x.ToString();
        }

        private void B_point_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += ",";
        }
    }
}
