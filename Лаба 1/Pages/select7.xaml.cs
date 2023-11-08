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
    /// Логика взаимодействия для select7.xaml
    /// </summary>
    public partial class select7 : Page
    {
        public select7()
        {
            InitializeComponent();
        }

        private void CBgroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
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
                    vivod2 = vivod2.Where(x => x.sprav.full_name == "Иванов Иван Иванович").ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 2:
                    vivod2 = vivod2.Where(x => x.sprav.full_name == "Петров Пётр Сергеевич").ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 3:
                    vivod2 = vivod2.Where(x => x.sprav.full_name == "Чумаков Алексей Николаевич").ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 4:
                    vivod2 = vivod2.Where(x => x.sprav.full_name == "Винокуров Сергей Иванович").ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
            }
            switch (CBgroup2.SelectedIndex) // фильтрация 
            {
                case 1:
                    vivod2 = vivod2.Where(x => x.uchet.tarif >= 100 && x.uchet.tarif <= 300).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;
                case 2:
                    vivod2 = vivod2.Where(x => x.uchet.tarif >= 300 && x.uchet.tarif <= 500).ToList();
                    SpavochnikDG.ItemsSource = vivod2;
                    break;


            }
            SpavochnikDG.ItemsSource = vivod2;
        }
    

        
        private void vvodButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void SpavochnikDG_Loaded(object sender, RoutedEventArgs e)
        {
            Update();  
        }

        private void CBgroup2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }
    }
}
