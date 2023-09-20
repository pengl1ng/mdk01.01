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
    /// Логика взаимодействия для PR3Page.xaml
    /// </summary>
    public partial class PR3Page : Page
    {
        public PR3Page()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, RoutedEventArgs e)
        {
            double x0 = double.Parse(tboxX0.Text);
            double xk = double.Parse(tboxXk.Text);
            double dx = double.Parse(tboxDx.Text);
            double b = double.Parse(tboxB.Text);

            lboxRes.Items.Add("Выполнил: Самозванцев В.А. Вариант: 18");

            double y = 0;

            for (double i = x0; i <= xk; i += dx)
            {
                y = 0.8 * Math.Pow(10, -5) * Math.Pow((Math.Pow(i, 3) + Math.Pow(b, 3)), 7.0/6.0);
                lboxRes.Items.Add($"x = {Math.Round(i, 2)}; y = {y}");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lboxRes.Items.Clear();
        }

        private void btnToPR7_Click(object sender, RoutedEventArgs e)
        {
            Helper.MainFrame.Navigate(new PR7Page());
        }
    }
}
