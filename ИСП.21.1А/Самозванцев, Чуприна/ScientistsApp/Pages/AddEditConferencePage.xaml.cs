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
    /// Логика взаимодействия для AddEditConferencePage.xaml
    /// </summary>
    public partial class AddEditConferencePage : Page
    {
        DbEntities context = DbEntities.GetContext();
        Conferences conference;
        public AddEditConferencePage(Conferences conferences)
        {
            conference = conferences;
            InitializeComponent();
            DataContext = conference;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (conference.ConfId == 0)
                {
                    if (context.Conferences.FirstOrDefault(x => x.ConfName == conference.ConfName) == null) context.Conferences.Add(conference);
                    else MessageBox.Show("Конференция с данным названием уже существует");
                }
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
