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

namespace Калькулейтер
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double value_, d, v, c, k = 0;
        string a = "";
        string b = "";
        bool znak = true;
        bool znakb = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            Lenghth();
            if (c == 0)
            {
                a = "1";
            }
            else a = a + "1";
            table.Text = table.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            Lenghth();
            if (c == 0)
            {
                a = "2";
            }
            else a = a + "2";
            table.Text = table.Text + "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            Lenghth();
            if (c == 0)
            {
                a = "3";
            }
            else a = a + "3";
            table.Text = table.Text + "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            Lenghth();
            if (c == 0)
            {
                a = "4";
            }
            else a = a + "4";
            table.Text = table.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            Lenghth();
            if (c == 0)
            {
                a = "5";
            }
            else a = a + "5";
            table.Text = table.Text + "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            Lenghth();
            if (c == 0)
            {
                a = "6";
            }
            else a = a + "6";
            table.Text = table.Text + "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            Lenghth();
            if (c == 0)
            {
                a = "7";
            }
            else a = a + "7";
            table.Text = table.Text + "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            Lenghth();
            if (c == 0)
            {
                a = "8";
            }
            else a = a + "8";
            table.Text = table.Text + "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            Lenghth();
            if (c == 0)
            {
                a = "9";
            }
            else a = a + "9";
            table.Text = table.Text + "9";
        }

        private void noll_Click(object sender, RoutedEventArgs e)
        {
            Lenghth();
            if (c == 0)
            {
                a = "0";
            }
            else a = a + "0";
            table.Text = table.Text + "0";
        }

        private void Lenghth()
        {
            c = a.Length;
        }

        private void sec_vac_val()
        {
            if (value_ == 0)
            {
                b = a;
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (table.Text != "")
            {
                table.Text = table.Text + "+";
            }
            sec_vac_val();
            k = 1;
            Clear();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            Lenghth();
            table.Text = table.Text + "-";
            if (table.Text == "-")
            {
                znak = false;
            }

            if (c == 0 || value_ != 0)
            {
                znakb = false;
            }
            if (value_ == 0 && b == "")
            {
                b = a;
            }

            if (k == 0)
            {
                k = 1;
            }
            Clear();
        }

        private void multi_Click(object sender, RoutedEventArgs e)
        {
            if (table.Text != "")
            {
                table.Text = table.Text + " * ";
            }
            sec_vac_val();
            k = 3;
            Clear();
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            if (table.Text != "")
            {
                table.Text = table.Text + " / ";
            }
            sec_vac_val();
            k = 4;
            Clear();
        }

        private void eql_Click(object sender, RoutedEventArgs e)
        {
            switch (k)
            {
                case 1:
                    {
                        Parsing();
                        value_ = d + v;
                        table.Text = value_.ToString();
                        break;
                    }
                case 3:
                    {
                        Parsing();
                        value_ = d * v;
                        table.Text = value_.ToString();
                        break;
                    }
                case 4:
                    {
                        Parsing();
                        value_ = d / v;
                        table.Text = value_.ToString();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            Clear();
            b = value_.ToString();
            k = 0;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            b = "";
            value_ = 0;
            k = 0;
            table.Text = "";
            znak = true;
            znakb = true;
        }

        private void Clear()
        {
            a = "";
            c = 0;
        }

        private void Check_znak()
        {
            if (znak == false && value_ == 0)
            {
                d = -d;
                znak = true;
            }

            if (znakb == false)
            {
                v = -v;
                znakb = true;
            }
        }

        private void Parsing()
        {
            d = double.Parse(b);
            v = double.Parse(a);
            Check_znak();
        }
    }
}
