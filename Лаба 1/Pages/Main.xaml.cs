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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }
        
        private void vvod_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new Page1()); //переход на след страницу - МОДУЛИ!!!!!!
            //Nav.MFrame.Navigate(new DATA_PARA_BAZ()); // БД!!
        }

        private void vyborka_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new select3());// - БД
           // Nav.MFrame.Navigate(new SortLisc());
            

        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new poisk_Page()); // БД!!!
            //Nav.MFrame.Navigate(new poiskFIO()); // МОДУЛИИИИ
        }

        private void vichislenia_Click(object sender, RoutedEventArgs e)
        {
           Nav.MFrame.Navigate(new vychisleniePage());  //МОДУЛИ
            //Nav.MFrame.Navigate(new select()); // БД1!!!!!!!!!!!!!!!
        }

        private void otchety_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new otchetyPage());
        }

        private void vyhod_Click(object sender, RoutedEventArgs e)
        {
          Application.Current.Shutdown();
        }
    }
}
