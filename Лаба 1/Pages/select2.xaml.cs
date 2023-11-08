using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Лаба_1.AppData;
using Лаба_1.Pages;

namespace Лаба_1
{
    /// <summary>
    /// Логика взаимодействия для select2.xaml
    /// </summary>
    public partial class select2 : Page
    {
        public select2()
        {
            InitializeComponent();
            updateDG();
        }
        void updateDG()
        {
            var vivod2 = ConDB.context.uchetnaya.Select(x =>
                   new
                   {
                       uchet = x,
                       sprav = x.spravochniki,
                   }
                   ).ToList();
            vivod2 = vivod2.Where(x => x.sprav.aadress.ToLower().Contains(TBpoisk.Text.ToLower())).ToList();//поиск по бд
            if (!string.IsNullOrWhiteSpace(chislo.Text.ToString())) // проверка на 0 у 2-го текс.бокса
                vivod2 = vivod2.Where(x => x.uchet.quantity_of_kvatt > int.Parse(chislo.Text.ToString())).ToList();
            //выводится, то, что больше того, что мы написали
            SpavochnikDG.ItemsSource = vivod2; //сам вывод в DG

        }
        private void vvodButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack(); //назад
        }

        private void TBpoisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            updateDG(); //обновление при поиске
        }

        private void chislo_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(chislo.Text.ToString())) updateDG(); // проверка на буквы у 2-го текс.бокса
            }
            catch (FormatException) //ошибка, если буквы или спец.символы
            {
                MessageBox.Show("не надо буквы и спецсимволы вводить!!!");
                chislo.Text = "";
            }

        }

        private void vperedBTN_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new select5());
        }
    }
}
