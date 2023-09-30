using DbTestApp.Helpers;
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

namespace DbTestApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для StudentsPage.xaml
    /// </summary> 
    public partial class StudentsPage : Page
    {
        List<Ученики> origin = dbEntities.GetContext().Ученики.ToList();
        public StudentsPage()
        {
            InitializeComponent();
            var disc = dbEntities.GetContext().Ученики.Select(x => x.Предмет).Distinct().ToList();

            cboxPredmet.Items.Add("Все предметы");
            cboxPredmet.SelectedIndex = 0;
            
            foreach (var c in disc)
            {
                cboxPredmet.Items.Add(c);
            }

            dgStud.ItemsSource = origin;
        }

        private void cboxPredmet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string discipline = cboxPredmet.SelectedValue.ToString();

                if (discipline == "Все предметы")
                {
                    dgStud.ItemsSource = origin;
                }
                else
                {
                    dgStud.ItemsSource = origin.Where(x => x.Предмет == discipline);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tboxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgStud.ItemsSource = origin.Where(x => x.Фамилия.ToLower().Contains(tboxSearch.Text.ToLower())).ToList();
        }

        private void rbtnAsc_Click(object sender, RoutedEventArgs e)
        {
            dgStud.ItemsSource = origin.OrderBy(x => x.Баллы).ToList();
        }

        private void rbtnDesc_Click(object sender, RoutedEventArgs e)
        {
            dgStud.ItemsSource = origin.OrderByDescending(x => x.Баллы).ToList();
        }

        private void btnRes_Click(object sender, RoutedEventArgs e)
        {
            double avg = (double)origin.Select(x => x.Баллы).Average();
            double min = (double)origin.Min(x => x.Баллы);
            string minName = origin.First(x => x.Фамилия != null && x.Баллы == min).Фамилия;
            double max = (double)origin.Max(x => x.Баллы);
            string maxName = origin.First(x => x.Фамилия != null && x.Баллы == max).Фамилия;

            lboxRes.Items.Add($"Средний балл: {avg}");
            lboxRes.Items.Add($"Минимальный балл у {minName}: {min}");
            lboxRes.Items.Add($"Максимальный балл у {maxName}: {max}");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new PageAddEdit());
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudents = dgStud.SelectedItems.Cast<Ученики>().ToList();

            if (MessageBox.Show($"Удалить {selectedStudents.Count} студентов?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question)
                == MessageBoxResult.Yes)
            {
                try
                {
                    dbEntities.GetContext().Ученики.RemoveRange(selectedStudents);
                    dbEntities.GetContext().SaveChanges();
                    origin = dbEntities.GetContext().Ученики.ToList();
                    dgStud.ItemsSource = origin;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRef_Click(object sender, RoutedEventArgs e)
        {
            origin = dbEntities.GetContext().Ученики.ToList();
            dgStud.ItemsSource = origin;
        }
    }
}
