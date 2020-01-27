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

        bool Nove = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrvniPrepsani(int v)
        {
            textBlock.Text = Convert.ToString(v);
            textBlock_znamenka.Text = "";
            Nove = false;
            cisla.Clear();
            znamenka.Clear();
        }

        private void B_0_Click(object sender, RoutedEventArgs e)
        {
            if (Nove) PrvniPrepsani(0);
            else textBlock.Text += 0;
        }

        private void B_1_Click(object sender, RoutedEventArgs e)
        {
            if (Nove) PrvniPrepsani(1);
            else textBlock.Text += 1;
        }

        private void B_2_Click(object sender, RoutedEventArgs e)
        {
            if (Nove) PrvniPrepsani(2);
            else textBlock.Text += 2;
        }

        private void B_3_Click(object sender, RoutedEventArgs e)
        {
            if (Nove) PrvniPrepsani(3);
            else textBlock.Text += 3;
        }

        private void B_4_Click(object sender, RoutedEventArgs e)
        {
            if (Nove) PrvniPrepsani(4);
            else textBlock.Text += 4;
        }

        private void B_5_Click(object sender, RoutedEventArgs e)
        {
            if (Nove) PrvniPrepsani(5);
            else textBlock.Text += 5;
        }

        private void B_6_Click(object sender, RoutedEventArgs e)
        {
            if (Nove) PrvniPrepsani(6);
            else textBlock.Text += 6;
        }

        private void B_7_Click(object sender, RoutedEventArgs e)
        {
            if (Nove) PrvniPrepsani(7);
            else textBlock.Text += 7;
        }

        private void B_8_Click(object sender, RoutedEventArgs e)
        {
            if (Nove) PrvniPrepsani(8);
            else textBlock.Text += 8;
        }

        private void B_9_Click(object sender, RoutedEventArgs e)
        {
            if (Nove) PrvniPrepsani(9);
            else textBlock.Text += 9;
        }

        private void B_plus_Click(object sender, RoutedEventArgs e)
        {
            cisla.Add(Convert.ToDouble(textBlock.Text)); //přidam do listu cisel
            znamenka.Add('+'); //přidam do listu znamenek
            textBlock_znamenka.Text = "+ "; //upravim tb
            textBlock.Text = ""; //upravim 2. tb na nic
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
            Nove = true;
        }

        private void B_point_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += ",";
        }
    }
}
