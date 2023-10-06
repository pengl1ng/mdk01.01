using ScientistsApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace ScientistsApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        DbEntities context = DbEntities.GetContext();
        List<Reports> reports = DbEntities.GetContext().Reports.ToList();
        public MainPage()
        {
            InitializeComponent();

            var confs = DbEntities.GetContext().Conferences.Select(x => x.ConfName).Distinct().ToList();
            cboxConf.Items.Add("Все конференции");
            cboxConf.SelectedIndex = 0;
            foreach (var conf in confs)
            {
                cboxConf.Items.Add(conf);
            }

            var orgs = DbEntities.GetContext().Scientists.Select(x => x.ScOrg).Distinct().ToList();
            cboxOrg.Items.Add("Все организации");
            cboxOrg.SelectedIndex = 0;
            foreach (var org in orgs)
            {
                cboxOrg.Items.Add(org);
            }

            dgScientists.ItemsSource = reports;
        }

        private void cboxConf_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var conf = cboxConf.SelectedValue.ToString();
                if (conf == "Все конференции") dgScientists.ItemsSource = reports;
                else dgScientists.ItemsSource = reports.Where(x => x.Conferences.ConfName == conf);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void tboxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgScientists.ItemsSource = reports.Where(x => x.Scientists.ScFIO.ToLower().Contains(tboxSearch.Text.ToLower()));
        }

        private void cboxOrg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var org = cboxOrg.SelectedValue.ToString();
                if (org == "Все организации") dgScientists.ItemsSource = reports;
                else dgScientists.ItemsSource = reports.Where(x => x.Scientists.ScOrg == org);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new AddPage());
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var selectedSci = dgScientists.SelectedItems.Cast<Reports>().ToList();

            if ((MessageBox.Show($"Удалить информацию о {selectedSci.Count} докладах?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question)
                == MessageBoxResult.Yes))
            {
                try
                {
                    DbEntities.GetContext().Reports.RemoveRange(selectedSci);
                    DbEntities.GetContext().SaveChanges();
                    reports = DbEntities.GetContext().Reports.ToList();
                    dgScientists.ItemsSource = reports;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnRef_Click(object sender, RoutedEventArgs e)
        {
            reports = DbEntities.GetContext().Reports.ToList();
            dgScientists.ItemsSource = reports;
        }

        private void btnChangeRep_Click(object sender, RoutedEventArgs e)
        {
            Reports report = dgScientists.SelectedItem as Reports;
            AppHelper.mainFrame.Navigate(new EditReportPage(report));
        }

        private void btnChangeSci_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChangeConf_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
