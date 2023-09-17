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


        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double с;
            lstResult.Items.Add("ЛБ2. Выполнила Чуприна Вероника");
            lstResult.Items.Add($"x={x}");
            lstResult.Items.Add($"y={y}");
            int n = 0;
            if (rbtCos.IsChecked == true) n = 1;
            else if (rbtExp.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if ((x - y) == 0) с = Math.Pow((Math.Exp(x)- Math.Exp(-x))/2,2)+Math.Pow(y,2)+Math.Sin(y);
                    else if ((x - y) > 0) с = Math.Pow(((Math.Exp(x) - Math.Exp(-x)) / 2)-y,2)+Math.Cos(y);
                    else с = Math.Pow(y-((Math.Exp(x) - Math.Exp(-x)) / 2), 2)+Math.Tan(y);
                    lstResult.Items.Add($"Результат c ={Math.Round(с, 3)}");
                    break;
                case 1:
                    if ((x - y) == 0) с = Math.Pow(x, 4) + Math.Pow(y, 2) + Math.Sin(y);
                    else if ((x - y) > 0) с = Math.Pow(Math.Pow(x,2) - y, 2) + Math.Cos(y);
                    else с = Math.Pow(y - Math.Pow(x, 2), 2) + Math.Tan(y);
                    lstResult.Items.Add($"Результат c ={Math.Round(с, 3)}");
                    break;
                case 2:
                    if ((x - y) == 0) с = Math.Pow(Math.Exp(x), 2) + Math.Pow(y, 2) + Math.Sin(y);
                    else if ((x - y) > 0) с = Math.Pow(Math.Exp(x) - y, 2) + Math.Cos(y);
                    else с = Math.Pow(y - Math.Exp(x), 2) + Math.Tan(y);
                    lstResult.Items.Add($"Результат c ={Math.Round(с, 3)}");
                    break;
                default:
                    lstResult.Items.Add("Решение не найдено");
                    break;
            }

        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            lstResult.Items.Clear();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Helper.MainFrame.Navigate(new PR3Page());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Helper.MainFrame.Navigate(new PR1Page());
        }

    }

}
