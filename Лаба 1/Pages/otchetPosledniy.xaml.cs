using System;
using System.Collections.Generic;
using System.Data;
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
using Excel = Microsoft.Office.Interop.Excel;
using Page = System.Windows.Controls.Page;
using Лаба_1.AppData;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Office.Interop.Excel;

namespace Лаба_1.Pages
{
    /// <summary>
    /// Логика взаимодействия для otchetPosledniy.xaml
    /// </summary>
    public partial class otchetPosledniy : Page
    {
        public otchetPosledniy()
        {
            InitializeComponent(); Update();
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
            sheet.Rows.Font.Name = "Times New Romans";
            Excel.Range range2 = sheet.get_Range("A7", "D7");
            range2.EntireColumn.ColumnWidth = 30;
            Excel.Range _excelCells2 = (Excel.Range)sheet.get_Range("A1", "E1").Cells;
            sheet.Cells[1, 1] = DateTime.Now.ToString();
            _excelCells2 = sheet.get_Range("A1", "E1");
            _excelCells2.HorizontalAlignment = Excel.Constants.xlCenter;
            Range _excelCells1 = (Excel.Range)sheet.get_Range("A1", "E1").Cells;
            _excelCells1.Merge(Type.Missing);
            Range _excelCells4 = (Excel.Range)sheet.get_Range("A2", "E2").Cells;
            _excelCells4.Merge(Type.Missing);
            sheet.Shapes.AddPicture(@"C:\Users\k2510\Downloads\astranaut.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 730, 30, 185, 185);

            if (CBgroup2.SelectedIndex == 0)
            {

                sheet.Cells[1, 1].Font.Underline = true;
                sheet.Rows.Font.Name = "Times New Romans";
                Excel.Range r1 = sheet.Cells[1, 1];
                Excel.Range r2 = sheet.Cells[13, 5];
                Excel.Range rangeColor = sheet.get_Range(r1, r2);
                rangeColor.Borders.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            }
            if (CBgroup2.SelectedIndex == 1)
            {

                sheet.Cells[1,1].Font.Underline = true;
                sheet.Rows.Font.Name = "Times New Romans";
                Excel.Range r1 = sheet.Cells[1, 1];
                Excel.Range r2 = sheet.Cells[6, 5];
                Excel.Range rangeColor = sheet.get_Range(r1, r2);
                rangeColor.Borders.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            }
            if (CBgroup2.SelectedIndex == 2)
            {
                sheet.Cells[1, 1].Font.Underline = true;
                sheet.Rows.Font.Name = "Times New Romans";
                Excel.Range r1 = sheet.Cells[1, 1];
                Excel.Range r2 = sheet.Cells[5, 5];
                Excel.Range rangeColor = sheet.get_Range(r1, r2);
                rangeColor.Borders.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            }
            if (CBgroup2.SelectedIndex == 3)
            {
                sheet.Cells[1, 1].Font.Underline = true;
                sheet.Rows.Font.Name = "Times New Romans";
                Excel.Range r1 = sheet.Cells[1, 1];
                Excel.Range r2 = sheet.Cells[5, 5];
                Excel.Range rangeColor = sheet.get_Range(r1, r2);
                rangeColor.Borders.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            }
            if (CBgroup2.SelectedIndex == 4)
            {

                sheet.Cells[1, 1].Font.Underline = true;
                sheet.Rows.Font.Name = "Times New Romans";
                Excel.Range r1 = sheet.Cells[1, 1];
                Excel.Range r2 = sheet.Cells[6, 5];
                Excel.Range rangeColor = sheet.get_Range(r1, r2);
                rangeColor.Borders.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
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
                         ).ToList();

                switch (CBgroup2.SelectedIndex) // фильтрация 
                {
                    case 1:
                        vivod2 = vivod2.Where(x => x.uchet.tarif >= 100 && x.uchet.tarif <= 200).ToList();
                        SpavochnikDG.ItemsSource = vivod2;
                        break;
                    case 2:
                        vivod2 = vivod2.Where(x => x.uchet.tarif >= 200 && x.uchet.tarif <= 300).ToList();
                        SpavochnikDG.ItemsSource = vivod2;
                        break;
                    case 3:
                        vivod2 = vivod2.Where(x => x.uchet.tarif >= 300 && x.uchet.tarif <= 400).ToList();
                        SpavochnikDG.ItemsSource = vivod2;
                        break;
                    case 4:
                        vivod2 = vivod2.Where(x => x.uchet.tarif >= 400 && x.uchet.tarif <= 500).ToList();
                        SpavochnikDG.ItemsSource = vivod2;
                        break;
                }
                SpavochnikDG.ItemsSource = vivod2;
            }

            private void SpavochnikDG_Loaded(object sender, RoutedEventArgs e)
            {
                Update();
            }

            private void otchetyButton_Click(object sender, RoutedEventArgs e)
            {
                Nav.MFrame.GoBack();
            }

            private void CBgroup2_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                Update();
            }
        }
    
}
