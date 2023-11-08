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
    /// Логика взаимодействия для select6.xaml
    /// </summary>
    public partial class select6 : Page
    {
        public select6()
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

            if (!string.IsNullOrWhiteSpace(TBpoisk.Text.ToString())) // проверка на 0 у 2-го текс.бокса
                vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == int.Parse(TBpoisk.Text.ToString())).ToList();
            SpavochnikDG.ItemsSource = vivod2; //сам вывод в DG

        }
        private void TBpoisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            updateDG();
        }

        private void SpavochnikDG_Loaded(object sender, RoutedEventArgs e)
        {
            updateDG();
        }

        private void vvodButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void vpered_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new select7());
        }
    }
}
