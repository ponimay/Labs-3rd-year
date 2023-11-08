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

namespace Лаба_1.Pages
{
    /// <summary>
    /// Логика взаимодействия для select5.xaml
    /// </summary>
    public partial class select5 : Page
    {
        public select5()
        {
            InitializeComponent();
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
            
            vivod2 = vivod2.Where(x => x.sprav.full_name.ToLower().Contains(TBpoisk.Text.ToLower())).ToList();//поиск по бд
            if (!string.IsNullOrWhiteSpace(taifTB.Text.ToString())) // проверка на 0 у 2-го текс.бокса
                vivod2 = vivod2.Where(x => x.uchet.tarif >= int.Parse(taifTB.Text.ToString())).ToList();
            vivod2 = vivod2.Where(x => x.uchet.month_of_payment.ToLower().Contains(monthTB.Text.ToLower())).ToList();
            SpavochnikDG.ItemsSource = vivod2; //сам вывод в DG

        }

       
        private void taifTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(taifTB.Text.ToString())) updateDG(); // проверка на буквы у 2-го текс.бокса
            }
            catch (System.FormatException) //ошибка, если буквы или спец.символы
            {
                MessageBox.Show("Нужно ввести число");
                taifTB.Text = "";
            }

        }

        private void monthTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            updateDG();
        }

        private void vvodButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void TBpoisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            updateDG();
        }

        private void vperedBTN_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new select6());
        }

        private void SpavochnikDG_Loaded(object sender, RoutedEventArgs e)
        {
            updateDG();
        }
    }
}
