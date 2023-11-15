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

namespace FirstAppChupSamozvan.Pages
{
    /// <summary>
    /// Логика взаимодействия для PR2Page.xaml
    /// </summary>
    public partial class PR2Page : Page
    {
        public PR2Page()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, RoutedEventArgs e)
        {
            double m = double.Parse(tboxM.Text);
            double x = double.Parse(tboxX.Text);
            double u;

            lboxRes.Items.Add("Лаб. раб. 2. Выполнил: Самозванцев В.А.");
            lboxRes.Items.Add($"m = {m}");
            lboxRes.Items.Add($"x = {x}");

            int c = 0;

            if (rbtnKvad.IsChecked == true) c = 1;
            else if (rbtnExp.IsChecked == true) c = 2;

            switch(c)
            {
                case 0:
                    if (-1 < m && m < x) u = Math.Sin(5 * Math.Sinh(x) + 3 * m * Math.Abs(Math.Sinh(x)));
                    else if (x > m) u = Math.Cos(3 * Math.Sinh(x) + 5 * m * Math.Abs(Math.Sinh(x)));
                    else if (x == m) u = Math.Pow((Math.Sinh(x) + m), 2);
                    else
                    {
                        lboxRes.Items.Add("Решение не найдено");
                        break;
                    }

                    lboxRes.Items.Add($"Значение u = {Math.Round(u, 3)}");
                    break;
                case 1:
                    if (-1 < m && m < x) u = Math.Sin(5 * Math.Pow(x, 2) + 3 * m * Math.Abs(Math.Pow(x, 2)));
                    else if (x > m) u = Math.Cos(3 * Math.Pow(x, 2) + 5 * m * Math.Abs(Math.Pow(x, 2)));
                    else if (x == m) u = Math.Pow((Math.Pow(x, 2) + m), 2);
                    else
                    {
                        lboxRes.Items.Add("Решение не найдено");
                        break;
                    }

                    lboxRes.Items.Add($"Значение u = {Math.Round(u, 3)}");
                    break;
                case 2:
                    if (-1 < m && m < x) u = Math.Sin(5 * Math.Exp(x) + 3 * m * Math.Abs(Math.Exp(x)));
                    else if (x > m) u = Math.Cos(3 * Math.Exp(x) + 5 * m * Math.Abs(Math.Exp(x)));
                    else if (x == m) u = Math.Pow((Math.Exp(x) + m), 2);
                    else
                    {
                        lboxRes.Items.Add("Решение не найдено");
                        break;
                    }

                    lboxRes.Items.Add($"Значение u = {Math.Round(u, 3)}");
                    break;
                default:
                    lboxRes.Items.Add("Решение не найдено");
                    break;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lboxRes.Items.Clear();
        }

        private void btnToPR3_Click(object sender, RoutedEventArgs e)
        {
            Helper.MainFrame.Navigate(new PR3Page());
        }
    }
}
