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
    /// Логика взаимодействия для vychisleniePage.xaml
    /// </summary>
    public partial class vychisleniePage : Page
    {
        public vychisleniePage()
        {
            InitializeComponent();
        }

        private void vychislenie_Click(object sender, RoutedEventArgs e)
        {
            if (Nav.MFrame.CanGoBack)
            {
                Nav.MFrame.GoBack();
            }
        }
    }
}
