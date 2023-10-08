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
    /// Логика взаимодействия для EditReportPage.xaml
    /// </summary>
    public partial class EditReportPage : Page
    {
        DbEntities context = DbEntities.GetContext();
        Reports report = new Reports();

        public EditReportPage(Reports reports)
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

        private void cboxAuthor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //report.RepAuthor = context.Scientists.FirstOrDefault(x => x.ScFIO == cboxAuthor.SelectedValue.ToString()).ScId;
        }

        private void cboxConf_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //report.RepConf = context.Conferences.FirstOrDefault(x => x.ConfName == cboxConf.SelectedValue.ToString()).ConfId;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (tboxRepName.Text != "")
            {
                try
                {
                    report.RepTheme = tboxRepName.Text;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.GoBack();
        }
    }
}
