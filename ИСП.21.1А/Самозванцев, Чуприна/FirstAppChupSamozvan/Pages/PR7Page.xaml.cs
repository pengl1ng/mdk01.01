using Microsoft.SqlServer.Server;
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
    /// Логика взаимодействия для PR7Page.xaml
    /// </summary>
    public partial class PR7Page : Page
    {
        public PR7Page()
        {
            InitializeComponent();

            
        }
        private void btnBack2_Click(object sender, RoutedEventArgs e)
        {
           Helper.MainFrame.Navigate(new PR2Page());
        }

        private void btnCalc1_Click(object sender, RoutedEventArgs e)
        {
           Random rnd = new Random();
           lstResult.Items.Clear();
           int[] arr = new int[12];
           int n = 0, sum = 0;
           for (int i = 0; i < 12; i++)
              {
                n = rnd.Next(1, 25);
                arr[i] = n;
                lstResult.Items.Add(arr[i]);
                if (arr[i] % 2 == 0) sum += arr[i];
              }
                textBox.Text = "Сумма " + sum.ToString();

            }
        }

    }
}
