using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для FiltrFIOiTARIF.xaml
    /// </summary>
    public partial class FiltrFIOiTARIF : Page
    {
        public FiltrFIOiTARIF()
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
                    vivod2 = vivod2.OrderBy(x => x.sprav.full_name).ToList(); //по алфавиту
                    break;
                case 2:
                    vivod2 = vivod2.OrderByDescending(x => x.sprav.full_name).ToList(); //от я до а
                    break;
            }
            

            switch (COMBtarif.SelectedIndex) // фильтрация 
            {
                case 1:
                    vivod2 = vivod2.OrderBy(x => x.uchet.tarif).ToList();
                    // выборка с ограничением с 100 по 300
                    filtratsiaLV.ItemsSource = vivod2;
                    break;
                case 2:
                    vivod2 = vivod2.OrderByDescending(x => x.uchet.tarif).ToList();
                    filtratsiaLV.ItemsSource = vivod2;
                    break;
            }
            filtratsiaLV.ItemsSource = vivod2;

        }
        private void CombO_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void COMBtarif_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void vyborkaPage_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }
    }
}
