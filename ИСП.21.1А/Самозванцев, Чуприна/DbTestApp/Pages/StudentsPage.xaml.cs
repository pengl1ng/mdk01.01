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

        private void tboxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgStud.ItemsSource = origin.Where(x => x.Фамилия.Contains(tboxSearch.Text)).ToList();
        }
    }
}
