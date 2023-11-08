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

namespace Лаба_1
{
    /// <summary>
    /// Логика взаимодействия для select4.xaml
    /// </summary>
    public partial class select4 : Page
    {
        public select4()
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

            switch (CBgroup.SelectedIndex) // фильтрация 
            {
                case 1:
                    vivod2 = vivod2.Where(x => x.uchet.quantity_of_kvatt >= 0 && x.uchet.quantity_of_kvatt <= 5).ToList();
                    // выборка с ограничением с 100 по 300
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 2:
                    vivod2 = vivod2.Where(x => x.uchet.quantity_of_kvatt >= 6 && x.uchet.quantity_of_kvatt <= 10).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 3:
                    vivod2 = vivod2.Where(x => x.uchet.quantity_of_kvatt >= 11 && x.uchet.quantity_of_kvatt <= 20).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
              

            }
            SpavochnikDG.ItemsSource = vivod2;
        }
        private void vvodButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void CBgroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void SpavochnikDG_Loaded(object sender, RoutedEventArgs e)
        {
            Update();  
        }

        private void vpered_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new select7());
        }
    }
}
