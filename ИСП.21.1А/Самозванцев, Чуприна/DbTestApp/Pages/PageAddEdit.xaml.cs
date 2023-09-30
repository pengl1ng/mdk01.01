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
    /// Логика взаимодействия для PageAddEdit.xaml
    /// </summary>
    public partial class PageAddEdit : Page
    {
        dbEntities context = dbEntities.GetContext();
        private Ученики student = new Ученики();
        public PageAddEdit()
        {
            InitializeComponent();
            DataContext = student;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (tboxSurname.Text != "" && tboxObject.Text != ""
                && tboxSchool.Text != "" && tboxMark.Text != "")
            {
                try
                {
                    if (student.Id == 0) dbEntities.GetContext().Ученики.Add(student);
                    dbEntities.GetContext().SaveChanges();
                    AppHelper.mainFrame.GoBack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Значения полей не должны быть пустыми!", "Предупреждение");
        }
    }
}
