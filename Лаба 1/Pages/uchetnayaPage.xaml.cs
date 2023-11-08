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
    /// Логика взаимодействия для uchetnayaPage.xaml
    /// </summary>
    public partial class uchetnayaPage : Page
    {
        public uchetnayaPage()
        {
            InitializeComponent();
        }

        private void dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.Navigate(new dobavlenieUchetnaya(null));
        }
        void UpdateDB()
        {
            var vivod = vvodListView.ItemsSource = ConDB.context.uchetnaya.ToList(); //вывод в листвью из созданной бд

        }
        private void edit_Click(object sender, RoutedEventArgs e)
        {
            if (vvodListView.SelectedItems.Count > 1 && vvodListView.SelectedItems.Count != 5)
            {
                MessageBox.Show($"Ты выделил {vvodListView.SelectedItems.Count.ToString()} штуки!!!!!!!!! Ну зачем??? Надо 1", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (vvodListView.SelectedItems.Count >= 5)
            {
                MessageBox.Show($"Ты выделил {vvodListView.SelectedItems.Count.ToString()} штук!!!!!!!!! Ну зачем??? Надо 1", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (vvodListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Зачем ты жмёшь, когда ничего не выделил? где логика?", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Nav.MFrame.Navigate(new dobavlenieUchetnaya(vvodListView.SelectedItem as uchetnaya));
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var delUsers = vvodListView.SelectedItems.Cast<uchetnaya>().ToList();
            foreach (var delUser in delUsers)
            {
                if (ConDB.context.uchetnaya.Any(x => x.id_litsscheta == delUser.id_zapisi))
                {
                    MessageBox.Show("Данные уже используются в табл. учета", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            ConDB.context.uchetnaya.RemoveRange(delUsers);
            try
            {
                ConDB.context.SaveChanges();
                UpdateDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void vvodListView_Loaded(object sender, RoutedEventArgs e)
        {
            vvodListView.ItemsSource = ConDB.context.uchetnaya.ToList();
        }

        private void vvodButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }
    }
}
