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
    /// Логика взаимодействия для vyborkaPAge.xaml
    /// </summary>
    public partial class vyborkaPAge : Page
    {
        public vyborkaPAge()
        {
            InitializeComponent();
            Update();
        }

        private void vyborkaPage_Click(object sender, RoutedEventArgs e)
        {
            if (Nav.MFrame.CanGoBack)
            {
                Nav.MFrame.GoBack();
            }
        }

        void Update()
        {
            var filtr = ConDB.context.spravochniki.ToList(); 
            switch (SortCMB.SelectedIndex) // фильтрация 
            {
                case 1:
                    filtr = filtr.OrderBy(x => x.full_name).ToList(); //по алфавиту
                    break;
                case 2:
                    filtr = filtr.OrderByDescending(x => x.full_name).ToList(); //от я до а
                    break;
            }
             filtratsiaLV.ItemsSource = filtr;
        }
        private void SortCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)// при выборе опции в кмб
        {
            Update();
        }
    }
}
