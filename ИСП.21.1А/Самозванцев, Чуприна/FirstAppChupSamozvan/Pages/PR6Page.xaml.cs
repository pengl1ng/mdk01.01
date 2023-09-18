using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
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
    /// Логика взаимодействия для PR6Page.xaml
    /// </summary>
    public partial class PR6Page : Page
    {
        public PR6Page()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                lboxInput.Items.Add(sr.ReadLine());
            }
        }

        private void btnRes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = lboxInput.SelectedIndex;
                string str = (string)lboxInput.Items[index];
                int len = str.Length;
                int countOne = 0;
                int countZero = 0;
                int i = 0;
                while (i < len - 1)
                {
                    if (str[i] == '1')
                        countOne++;
                    if (str[i] == '0')
                        countZero++;
                    i++;
                }
                tblockRes.Text = $"Количество 0: {countZero} Колиечство 1: {countOne}";
                string line = lboxInput.SelectedItem.ToString();
                StreamWriter sw = new StreamWriter(@"Rezult.txt");
                sw.WriteLine($"Выполнили: Самозванцев, Чуприна гр. ИСП.21.1А");
                sw.WriteLine($"Изначальная строка: {line}");
                sw.WriteLine($"Количество 0: {countZero} Колиечство 1: {countOne}");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lboxInput.Items.Clear();
        }
    }
}
