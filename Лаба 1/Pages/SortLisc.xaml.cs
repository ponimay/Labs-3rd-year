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
    /// Логика взаимодействия для SortLisc.xaml
    /// </summary>
    public partial class SortLisc : Page
    {
        public SortLisc()
        {
            InitializeComponent();
            Update();
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
            switch (CombO.SelectedIndex) // фильтрация 
            {
                case 1:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 1).ToList();
                    filtratsiaLV.ItemsSource = vivod2;
                    break;
                case 2:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 2).ToList();
                    filtratsiaLV.ItemsSource = vivod2;
                    break;
                case 3:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 3).ToList();
                    filtratsiaLV.ItemsSource = vivod2;
                    break;
                case 4:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 4).ToList();
                    filtratsiaLV.ItemsSource = vivod2;
                    break;
                case 5:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 5).ToList();
                    filtratsiaLV.ItemsSource = vivod2;
                    break;
                case 6:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 6).ToList();
                    filtratsiaLV.ItemsSource = vivod2;
                    break;
                case 7:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 7).ToList();
                    filtratsiaLV.ItemsSource = vivod2;
                    break;
                case 8:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 8).ToList();
                    filtratsiaLV.ItemsSource = vivod2;
                    break;
                case 9:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 9).ToList();
                    filtratsiaLV.ItemsSource = vivod2;
                    break;
                case 10:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 10).ToList();
                    filtratsiaLV.ItemsSource = vivod2;
                    break;

            }
            filtratsiaLV.ItemsSource = vivod2; // вывод в DG
        }
        private void CombO_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void vpered_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new FiltrFIOiTARIF());
        }

        private void vyborkaPage_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }
    }
}
