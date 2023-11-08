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
    /// Логика взаимодействия для select.xaml
    /// </summary>
    public partial class select : Page
    {
        public select()
        {
            InitializeComponent();
            var selectInfo = ConDB.context.uchetnaya.Select(x =>
            new
            {
                uchet = x
                //Sum = x.quantity_of_kvatt * x.tarif
            }).ToList();
            SpavochnikDG.ItemsSource = selectInfo;
        }

        private void vvodButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }
    }
}
