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

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lboxRes.Items.Add("ПР 7. Вариант 18. Выполнил: Самозванцев В.А.");
            int[] z = new int[35];
            var rdn = new Random();

            int p = 1;
            int s = 0;
            int val = 0;

            for (int i = 0; i < z.Length; i++)
            {
                z[i] = rdn.Next(-20, 20);
            }

            for (int i = 0; i < z.Length; i++)
            {
                val = z[i];

                lboxRes.Items.Add($"Элемент {i+1} = {val}");

                if (val % 2 == 0 && val < 3) s += val;

                if (val % 2 != 0 && val > 1) p *= val;
            }

            lboxRes.Items.Add($"S = {s}");
            lboxRes.Items.Add($"P = {p}");
            lboxRes.Items.Add($"R = {s + p}");
        }

        private void btnCLear_Click(object sender, RoutedEventArgs e)
        {
            lboxRes.Items.Clear();
        }
    }
}
