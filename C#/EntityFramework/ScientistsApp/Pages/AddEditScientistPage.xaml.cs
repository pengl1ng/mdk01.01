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
using System.Xml;

namespace ScientistsApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditScientistPage.xaml
    /// </summary>
    public partial class AddEditScientistPage : Page
    {
        DbEntities context = DbEntities.GetContext();
        Scientists scientist;
        public AddEditScientistPage(Scientists scientists)
        {
            scientist = scientists;
            InitializeComponent();
            DataContext = scientist;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (scientist.ScId == 0) 
                {
                    if (context.Scientists.FirstOrDefault(x => x.ScFIO == scientist.ScFIO) == null) context.Scientists.Add(scientist);
                    else MessageBox.Show("Ученый с данным ФИО уже существует");
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
