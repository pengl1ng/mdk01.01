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
    /// Логика взаимодействия для ConferencesPage.xaml
    /// </summary>
    public partial class ConferencesPage : Page
    {
        DbEntities context = DbEntities.GetContext();
        List<Conferences> conferences = DbEntities.GetContext().Conferences.ToList();
        public ConferencesPage()
        {
            InitializeComponent();
            dgConferences.ItemsSource = conferences;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new AddEditConferencePage(new Conferences()));
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var selectedConf = dgConferences.SelectedItems.Cast<Conferences>().ToList();

            if ((MessageBox.Show($"Удалить информацию о {selectedConf.Count} конференциях?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question)
                == MessageBoxResult.Yes))
            {
                try
                {
                    context.Conferences.RemoveRange(selectedConf);
                    context.SaveChanges();
                    dgConferences.ItemsSource = context.Conferences.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnRef_Click(object sender, RoutedEventArgs e)
        {
            dgConferences.ItemsSource = context.Conferences.ToList();
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.GoBack();
        }

        private void btnChangeConf_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new AddEditConferencePage((sender as Button).DataContext as Conferences));
        }
    }
}
