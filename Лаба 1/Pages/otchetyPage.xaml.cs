using Microsoft.Office.Interop.Excel;
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
using Лаба_1.AppData;
using Лаба_1.Pages;
using Excel = Microsoft.Office.Interop.Excel;
using Page = System.Windows.Controls.Page;

namespace Лаба_1
{
    /// <summary>
    /// Логика взаимодействия для otchetyPage.xaml
    /// </summary>
    public partial class otchetyPage : Page
    {
        public otchetyPage()
        {
            InitializeComponent(); Update();             
        }

        private void otchetyButton_Click(object sender, RoutedEventArgs e)
        {
            if (Nav.MFrame.CanGoBack)
            {
                Nav.MFrame.GoBack();
            }
        }
        void Update()
        {
            var vivod2 = ConDB.context.uchetnaya.Select(x =>
                     new
                     {
                         uchet = x,
                         sprav = x.spravochniki,
                         Count = ConDB.context.uchetnaya.Count(y => y.id_litsscheta == x.id_litsscheta),
                         Sum = x.id_litsscheta * x.tarif
                     }
                     ).Where(o => o.uchet.month_of_payment == "Май").ToList();
            SpavochnikDG.ItemsSource = vivod2;
        }
        private void sozdat_otchet_Click(object sender, RoutedEventArgs e)
        {
            //Объявляем приложение
            Excel.Application app = new Excel.Application();
            app.Visible = true;
            Excel.Workbook workbook = app.Workbooks.Add(System.Reflection.Missing.Value);
            //Отключить отображение окон с сообщениями
            Excel.Worksheet sheet = (Excel.Worksheet)workbook.Sheets[1];

            for (int j = 0; j < SpavochnikDG.Columns.Count; j++)
            {
                Excel.Range range = (Excel.Range)sheet.Cells[3, j + 1];
                sheet.Cells[3, j + 1].Font.Bold = true;
                sheet.Columns[j + 1].ColumnWidth = 15;
                range.Value = SpavochnikDG.Columns[j].Header;
            }
            for (int j = 0; j < SpavochnikDG.Columns.Count; j++)
            {
                for (int i = 0; i < SpavochnikDG.Items.Count; i++)
                {
                    TextBlock b = SpavochnikDG.Columns[j].GetCellContent(SpavochnikDG.Items[i]) as TextBlock;
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[i + 4, j + 1];
                    range.Value = b.Text;

                }
            }
            Excel.Range range2 = sheet.get_Range("A7", "D7");
            range2.EntireColumn.ColumnWidth = 10;
            Excel.Range _excelCells1 = (Excel.Range)sheet.get_Range("A7", "D7").Cells;
            // Производим объединение
            _excelCells1.Merge(Type.Missing);
            sheet.Cells[7, 1] = "Итого:";
            sheet.Cells[7, 5] = $"=E{4}+E{5}+E{6}";
            Excel.Range _excelCells2 = (Excel.Range)sheet.get_Range("A1", "E1").Cells;
            Excel.Range _excelCells3 = (Excel.Range)sheet.get_Range("A2", "E2").Cells;
            _excelCells2.Merge(Type.Missing);
            _excelCells3.Merge(Type.Missing);
            sheet.Cells[1, 1] = "Ведомость оплаты за электроэнергию";
            sheet.Cells[2, 1] = "за Май месяц";
            _excelCells2 = sheet.get_Range("A1", "E1");
            _excelCells3 = sheet.get_Range("A2", "E2");
            _excelCells2.HorizontalAlignment = Excel.Constants.xlCenter;
            _excelCells3.HorizontalAlignment = Excel.Constants.xlCenter;

        }

        private void SpavochnikDG_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void vperedBTN_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new otchetPDF());
        }
    }

  
    
}
