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

namespace Лаба_1
{
    /// <summary>
    /// Логика взаимодействия для poisk_Page.xaml
    /// </summary>
    public partial class poisk_Page : Page
    {
        public poisk_Page()
        {
            InitializeComponent();
            UpdateLV();
        }

        
        private void ButtonBackinPoisk_Click(object sender, RoutedEventArgs e)
        {
           if (Nav.MFrame.CanGoBack)
            {
                Nav.MFrame.GoBack();
            }
        }

        void UpdateLV()
        {
            var vivod = ConDB.context.spravochniki.ToList(); //вывод в листвью из созданной бд
            vivod = vivod.Where(x => x.full_name.ToLower().Contains(poiskTB.Text.ToLower())).ToList();//поиск по бд

            poiskLV.ItemsSource = vivod;
        }

        private void poiskTB_TextChanged(object sender, TextChangedEventArgs e)// поиск по изменению 
        {
            UpdateLV();
        }

        private void vperedBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new select2());
        }
    }
}
