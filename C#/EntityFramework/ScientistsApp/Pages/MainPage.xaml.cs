using ScientistsApp.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
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
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace ScientistsApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        DbEntities context = DbEntities.GetContext();
        List<Reports> reports = DbEntities.GetContext().Reports.ToList();
        List<Reports> current = new List<Reports>();
        public MainPage()
        {
            InitializeComponent();

            current = reports;
            dgReports.ItemsSource = current;

            cboxConf.ItemsSource = context.Conferences.ToList();
            cboxConf.SelectedValue = "ConfId";
            cboxConf.DisplayMemberPath = "ConfName";

            cboxOrg.ItemsSource = context.Scientists.Select(x => x.ScOrg).Distinct().ToList(); 
        }
        /// <summary>
        /// Обновление фильтров
        /// </summary>
        private void UpdateFilters()
        {
            current = reports.Where(x => x.Scientists.ScFIO.ToLower().Contains(tboxSearch.Text.ToLower())).ToList();
            if (cboxConf.SelectedIndex != -1) current = current.Where(x => x.RepConf == cboxConf.SelectedIndex + 1).ToList();
            if (cboxOrg.SelectedIndex != -1) current = current.Where(x => x.Scientists.ScOrg == cboxOrg.SelectedValue.ToString()).ToList();
            dgReports.ItemsSource = current;
        }

        private void cboxConf_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateFilters();
        }

        private void tboxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateFilters();
        }

        private void cboxOrg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateFilters();
        }
        /// <summary>
        /// Переход на страницу добавляения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new AddEditReportsPage(new Reports()));
        }
        /// <summary>
        /// Удаление доклада
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var selectedRep = dgReports.SelectedItems.Cast<Reports>().ToList();

            if ((MessageBox.Show($"Удалить информацию о {selectedRep.Count} докладах?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question)
                == MessageBoxResult.Yes))
            {
                try
                {
                    context.Reports.RemoveRange(selectedRep);
                    context.SaveChanges();
                    reports = context.Reports.ToList();
                    dgReports.ItemsSource = reports;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        /// <summary>
        /// Обновление данных в дата гриде
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRef_Click(object sender, RoutedEventArgs e)
        {
            reports = context.Reports.ToList();
            dgReports.ItemsSource = reports;
        }
        /// <summary>
        /// Переход на страницу изменения доклада
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeRep_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new AddEditReportsPage((sender as Button).DataContext as Reports));
        }
        /// <summary>
        /// Очистка фильтров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearFilters_Click(object sender, RoutedEventArgs e)
        {
            cboxConf.SelectedIndex = -1;
            cboxOrg.SelectedIndex = -1;
            tboxSearch.Text = "";
            current = reports;
            dgReports.ItemsSource = current;
        }

        private void btnToSci_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new ScientistsPage());
        }

        private void btnToConfs_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new ConferencesPage());
        }

        private void btnToLv_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new ReportsLvPage());
        }

        private void btnPrintToExcel_Click(object sender, RoutedEventArgs e)
        {
            var app = new Excel.Application();

            Excel.Workbook wb = app.Workbooks.Add();
            Excel.Worksheet ws = app.Worksheets.Item[1];

            int indexRows = 1;

            ws.Cells[1][indexRows] = "Номер";
            ws.Cells[2][indexRows] = "Тема доклада";
            ws.Cells[3][indexRows] = "ФИО докладчика";
            ws.Cells[4][indexRows] = "Конференция";
            ws.Cells[5][indexRows] = "Дата доклада";

            var listReps = context.Reports.ToList();
            foreach (var reps in listReps)
            {
                indexRows++;
                ws.Cells[1][indexRows] = indexRows - 1;
                ws.Cells[2][indexRows] = reps.RepTheme;
                ws.Cells[3][indexRows] = reps.Scientists.ScFIO;
                ws.Cells[4][indexRows] = reps.Conferences.ConfName;
                ws.Cells[5][indexRows] = reps.Conferences.ConfDate;
            }

            app.Visible = true;
        }

        private void btnPrintShab_Click(object sender, RoutedEventArgs e)
        {
            var app = new Excel.Application();

            Excel.Workbook wb = app.Workbooks.Open($"" + $"{Directory.GetCurrentDirectory()}" + $"\\Шаблон.xlsx");
            Excel.Worksheet worksheet = (Excel.Worksheet)wb.Worksheets[1];

            int indexRows = 2;
            worksheet.Cells[1][indexRows] = "Номер";
            worksheet.Cells[2][indexRows] = "Тема доклада";
            worksheet.Cells[3][indexRows] = "ФИО докладчика";
            worksheet.Cells[4][indexRows] = "Конференция";
            worksheet.Cells[5][indexRows] = "Дата доклада";

            var listReps = context.Reports.ToList();

            foreach (var reps in listReps)
            {
                indexRows++;
                worksheet.Cells[1][indexRows] = indexRows - 2;
                worksheet.Cells[2][indexRows] = reps.RepTheme;
                worksheet.Cells[3][indexRows] = reps.Scientists.ScFIO;
                worksheet.Cells[4][indexRows] = reps.Conferences.ConfName;
                worksheet.Cells[5][indexRows] = reps.Conferences.ConfDate;
            }
            //показать Excel
            app.Visible = true;
        }

        private void btnPrintWord_Click(object sender, RoutedEventArgs e)
        {
            var app = new Word.Application();
            Word.Document doc = app.Documents.Add();
            var listReps = context.Reports.ToList();

            foreach (var reps in listReps)
            {
                Word.Paragraph paragraph = doc.Paragraphs.Add();
                Word.Range range = paragraph.Range;
                range.Text = $"Тема доклада: {reps.RepTheme}";
                range.InsertParagraphAfter();

                Word.Paragraph parFIO = doc.Paragraphs.Add();
                Word.Range rangeFIO = parFIO.Range;
                rangeFIO.Text = $"ФИО докладчика: {reps.Scientists.ScFIO}";
                rangeFIO.InsertParagraphAfter();

                Word.Paragraph parConf = doc.Paragraphs.Add();
                Word.Range rangeConf = parConf.Range;
                rangeConf.Text = $"Конференция: {reps.Conferences.ConfName}";
                rangeConf.InsertParagraphAfter();

                Word.Paragraph parDate = doc.Paragraphs.Add();
                Word.Range rangeDate = parDate.Range;
                rangeDate.Text = $"Дата: {reps.Conferences.ConfDate.Day}.{reps.Conferences.ConfDate.Month}." +
                    $"{reps.Conferences.ConfDate.Year}";
                rangeDate.InsertParagraphAfter();

                if (reps != listReps.LastOrDefault())
                {
                    doc.Words.Last.InsertBreak(Word.WdBreakType.wdPageBreak);
                }
            }

            app.Visible = true;
        }
    }
}