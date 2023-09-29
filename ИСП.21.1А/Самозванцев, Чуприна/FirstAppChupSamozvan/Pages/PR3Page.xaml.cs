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

        private void btnNext1_Click(object sender, RoutedEventArgs e)
        {
            Helper.MainFrame.Navigate(new PR7Page());
        }

        private void btnBack1_Click(object sender, RoutedEventArgs e)
        {
            Helper.MainFrame.Navigate(new PR2Page());
        }

        private void btnCalc1_Click(object sender, RoutedEventArgs e)
        {
            double x0 = double.Parse(txtX0.Text);
            double xk = double.Parse(txtXk.Text);
            double dx = double.Parse(txtDx.Text);
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double y;
            double x = x0;
            lstResult.Items.Add("ЛБ3. Выполнила Чуприна Вероника");
            while (x <= (xk + dx) / 2)
            {
                y = a * Math.Pow(x, 3)+Math.Pow(b,5/4)*x*Math.Exp(-x);
                lstResult.Items.Add($"x ={x}, y={y}");
                x = x + dx;

            }
        }
    }

}
