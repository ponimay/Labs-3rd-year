using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using System.Windows.Controls.Primitives;

namespace Лаба_1.Pages
{
    /// <summary>
    /// Логика взаимодействия для otchetPDF.xaml
    /// </summary>
    public partial class otchetPDF : Page
    {
        public otchetPDF()
        {
            InitializeComponent();Update();
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
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf";
            if(save.ShowDialog() == true)
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));
                doc.Open();
                BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font font = new Font(baseFont, Font.DEFAULTSIZE, Font.NORMAL);
                PdfPTable table = new PdfPTable(SpavochnikDG.Columns.Count);
                foreach (DataGridColumn column in SpavochnikDG.Columns)
                {
                    table.AddCell(new PdfPCell(new Phrase(column.Header.ToString(),font)));
                }
                foreach (var item  in SpavochnikDG.Items)
                {
                    foreach(var column in SpavochnikDG.Columns)
                    {
                        var cellValue = column.GetCellContent(item) as TextBlock;
                        if(cellValue != null)
                        {
                            table.AddCell(new PdfPCell(new Phrase(cellValue.Text, font)));
                        }
                    }
                }
                
                doc.Add(table);
                doc.Close();
                MessageBox.Show("Файл записан");
                System.Diagnostics.Process.Start(save.FileName);
                MessageBox.Show("Файл сохранён");
               // doc.Close();
            }
        }

      

        private void otchetyButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();   
        }

        private void SpavochnikDG_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void vpered_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new otchetPosledniy());
        }
    }
}
