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
    /// Логика взаимодействия для PR1Page.xaml
    /// </summary>
    public partial class PR1Page : Page
    {
        public PR1Page()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(tboxX.Text);
            double y = Convert.ToDouble(tboxY.Text);
            double z = Convert.ToDouble(tboxZ.Text);

            double t = ((2 * Math.Cos(x - Math.PI / 6)) / (0.5 + Math.Pow(Math.Sin(y), 2)))
                * (1 + (Math.Pow(z, 2) / 3 - (Math.Pow(z, 2) / 5)));

            lboxRes.Items.Add("ПР1 Самозванцев, Чуприна гр. ИСП.21.1А");
            lboxRes.Items.Add($"x = {x}");
            lboxRes.Items.Add($"y = {y}");
            lboxRes.Items.Add($"z = {z}");
            lboxRes.Items.Add($"Результат: t = {t}");
        }

        private void btnToPR2_Click(object sender, RoutedEventArgs e)
        {
            Helper.MainFrame.Navigate(new PR2Page());
        }
    }
}
