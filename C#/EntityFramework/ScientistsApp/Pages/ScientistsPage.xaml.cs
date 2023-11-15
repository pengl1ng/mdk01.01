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
    /// Логика взаимодействия для ScientistsPage.xaml
    /// </summary>
    public partial class ScientistsPage : Page
    {
        DbEntities context = DbEntities.GetContext();
        List<Scientists> scientists = DbEntities.GetContext().Scientists.ToList();
        public ScientistsPage()
        {
            InitializeComponent();
            dgScientists.ItemsSource = scientists;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new AddEditScientistPage(new Scientists()));
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var selectedSci = dgScientists.SelectedItems.Cast<Scientists>().ToList();

            if ((MessageBox.Show($"Удалить информацию о {selectedSci.Count} ученых?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question)
                == MessageBoxResult.Yes))
            {
                try
                {
                    context.Scientists.RemoveRange(selectedSci);
                    context.SaveChanges();
                    dgScientists.ItemsSource = context.Scientists.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnRef_Click(object sender, RoutedEventArgs e)
        {
            dgScientists.ItemsSource = context.Scientists.ToList();
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.GoBack();
        }

        private void btnChangeSci_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new AddEditScientistPage((sender as Button).DataContext as Scientists));
        }

        private void tboxSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (tboxSearch.Text != "") dgScientists.ItemsSource = context.Scientists.Where(x => x.ScFIO.ToLower().Contains(tboxSearch.Text.ToLower())).ToList();
            else dgScientists.ItemsSource = context.Scientists.ToList();
        }
    }
}
