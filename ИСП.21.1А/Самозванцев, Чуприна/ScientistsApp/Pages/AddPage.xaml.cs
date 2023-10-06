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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        DbEntities context = DbEntities.GetContext();
        private Scientists scientist = new Scientists();
        private Conferences conference = new Conferences();
        private Reports report = new Reports();
        public AddPage()
        {
            InitializeComponent();
            UpdateData();
            spSci.DataContext = scientist;
            spConf.DataContext = conference;
            spRep.DataContext = report;
        }

        /// <summary>
        /// Обновление данных в комбо боксах
        /// </summary>
        private void UpdateData()
        {
            try
            {
                cboxRepAuthor.Items.Clear();
                cboxRepConf.Items.Clear();

                var sc = context.Scientists.Select(x => x.ScFIO).Distinct().ToList();
                var cf = context.Conferences.Select(x => x.ConfName).Distinct().ToList();

                foreach (var a in sc)
                {
                    cboxRepAuthor.Items.Add(a);
                }

                foreach (var c in cf)
                {
                    cboxRepConf.Items.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Добавление ученого
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveSci_Click(object sender, RoutedEventArgs e)
        {
            if (tboxScFIO.Text != "" && tboxScDeg.Text != "" && tboxScCountry.Text != "" && tboxScOrg.Text != "")
            {
                try
                {
                    if (context.Scientists.FirstOrDefault(x => x.ScFIO == scientist.ScFIO) == null)
                    {
                        context.Scientists.Add(scientist);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show($"Ученый с ФИО {scientist.ScFIO} уже существует", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
                MessageBox.Show("Поля не должны бать пустыми!");
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            UpdateData();
        }

        /// <summary>
        /// Добавление конференции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void btnSaveConf_Click(object sender, RoutedEventArgs e)
        {
            if (conference.ConfName != "" && conference.ConfName != "" && conference.ConfName != "")
            {
                try
                {
                    if (context.Conferences.FirstOrDefault(x => x.ConfName == conference.ConfName) == null)
                    {
                        context.Conferences.Add(conference);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show($"Конференция с названием {conference.ConfName} уже существует", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
                MessageBox.Show("поля не должны бать пустыми!");
        }
        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.GoBack();
        }

        /// <summary>
        /// Добавление доклада
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveRep_Click(object sender, RoutedEventArgs e)
        {
            var conf = cboxRepConf.SelectedItem.ToString();
            var author = cboxRepAuthor.SelectedItem.ToString();

            if (conf != "" && author != "" && tboxRepTheme.Text != "")
            {
                try
                {
                    report.RepAuthor = context.Scientists.First(x => x.ScFIO == author).ScId;
                    report.RepConf = context.Conferences.First(x => x.ConfName == conf).ConfId;
                    if (context.Reports.FirstOrDefault(x => x.RepTheme == report.RepTheme) == null)
                    {
                        context.Reports.Add(report);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show($"Доклад с названием {report.RepTheme} уже существует", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
                MessageBox.Show("Поля не должны бать пустыми!");
        }
    }
}