using ScientistsApp.Helpers;
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

namespace ScientistsApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditReportsPage.xaml
    /// </summary>
    public partial class AddEditReportsPage : Page
    {
        DbEntities context = DbEntities.GetContext();
        Reports report;
        public AddEditReportsPage(Reports reports)
        {
            report = reports;
            InitializeComponent();
            DataContext = report;

            cboxAuthor.ItemsSource = context.Scientists.ToList();
            cboxAuthor.SelectedValuePath = "ScId";
            cboxAuthor.DisplayMemberPath = "ScFIO";

            cboxConf.ItemsSource = context.Conferences.ToList();
            cboxConf.SelectedValuePath = "ConfId";
            cboxConf.DisplayMemberPath = "ConfName";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (report.RepId == 0 && context.Reports.FirstOrDefault(x => x.RepTheme == report.RepTheme) == null) context.Reports.Add(report);
                context.SaveChanges();
                MessageBox.Show("Данные сохранены");
                AppHelper.mainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.GoBack();
        }
    }
}
