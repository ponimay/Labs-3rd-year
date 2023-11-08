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

namespace Лаба_1
{
    /// <summary>
    /// Логика взаимодействия для select3.xaml
    /// </summary>
    public partial class select3 : Page
    {
        public select3()
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
                    vivod2 = vivod2.Where(x => x.uchet.tarif >= 100 && x.uchet.tarif <= 300).ToList();
                    // выборка с ограничением с 100 по 300
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 2:
                    vivod2 = vivod2.Where(x => x.uchet.tarif >= 300 && x.uchet.tarif <= 600).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 3:
                    vivod2 = vivod2.Where(x => x.uchet.tarif >= 600 && x.uchet.tarif <= 9999).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;

            }
            switch (CombO.SelectedIndex) // фильтрация 
            {
                case 1:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 1).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 2:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 2).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 3:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 3).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 4:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 4).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 5:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 5).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 6:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 6).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 7:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 7).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 8:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 8).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 9:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 9).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 10:
                    vivod2 = vivod2.Where(x => x.uchet.id_litsscheta == 10).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;

            }
            SpavochnikDG.ItemsSource = vivod2; // вывод в DG
        }

        private void CBgroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void vvodButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void CombO_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void vperedBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new select4());
        }
    }
}
