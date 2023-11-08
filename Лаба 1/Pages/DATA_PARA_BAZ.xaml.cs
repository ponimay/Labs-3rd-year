using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
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
    /// Логика взаимодействия для DATA_PARA_BAZ.xaml
    /// </summary>
    public partial class DATA_PARA_BAZ : Page
    {
        public DATA_PARA_BAZ()
        {
            InitializeComponent();
            dobav();
        }

        void dobav()
        {
            var prod = DG.ItemsSource = ConDB.context.spravochniki.ToList();

        }
        private void vvodButton_Click(object sender, RoutedEventArgs e)
        {

            if (Nav.MFrame.CanGoBack) //назад
            {
                Nav.MFrame.GoBack();
            }
        }

        private void dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new dobavleniePage(null));

        }

        private void DG_Loaded(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = ConDB.context.spravochniki.ToList();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var delUsers = DG.SelectedItems.Cast<spravochniki>().ToList();
            foreach (var delUser in delUsers)
            {
                if (ConDB.context.uchetnaya.Any(x => x.id_litsscheta == delUser.id_schet))
                {
                    MessageBox.Show("Данные уже используются в табл. учета", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            ConDB.context.spravochniki.RemoveRange(delUsers);
            try
            {
                ConDB.context.SaveChanges();
                dobav(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItems.Count > 1 && DG.SelectedItems.Count != 5)
            {
                MessageBox.Show($"Ты выделил {DG.SelectedItems.Count.ToString()} штуки!!!!!!!!! Ну зачем??? Надо 1", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (DG.SelectedItems.Count >= 5)
            {
                MessageBox.Show($"Ты выделил {DG.SelectedItems.Count.ToString()} штук!!!!!!!!! Ну зачем??? Надо 1", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (DG.SelectedItems.Count == 0)
            {
                MessageBox.Show("Зачем ты жмёшь, когда ничего не выделил? где логика?", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Nav.MFrame.Navigate(new dobavleniePage(DG.SelectedItem as spravochniki));
        }
    }
}
