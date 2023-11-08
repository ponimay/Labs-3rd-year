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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Лаба_1.AppData;

namespace Лаба_1
{
    /// <summary>
    /// Логика взаимодействия для dobavleniePage.xaml
    /// </summary>
    public partial class dobavleniePage : Page
    {
        spravochniki Spravochniki;
        bool checkNew;
        public dobavleniePage(spravochniki s)
        {
            InitializeComponent();
            if (s == null)
            {
                s = new spravochniki();
                checkNew = true;

            }
            else
                checkNew = false;
            DataContext = Spravochniki = s;
        }

        
        
        private void nazad_Click(object sender, RoutedEventArgs e)
        {
                Nav.MFrame.GoBack();
                
        }
        
        private void dobavit_Click(object sender, RoutedEventArgs e)
        {
            if(checkNew)
            {
                ConDB.context.spravochniki.Add(Spravochniki);
            }
            try
            {
                ConDB.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            Nav.MFrame.GoBack();
        }

        private void FIOtextb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!FIOtextb.Text.All(char.IsDigit)) { }

            else
            {
                MessageBox.Show("Сюда надо вводить буквы");
                FIOtextb.Text = "Иванов";
            }
        }

        private void Адрес_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Адрес.Text.All(char.IsDigit)) { }

            else
            {
                MessageBox.Show("Сюда надо вводить буквы");
                Адрес.Text = "ул.";
            }
        }
    }
}
