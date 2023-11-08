using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// Логика взаимодействия для dobavlenieUchetnaya.xaml
    /// </summary>
    public partial class dobavlenieUchetnaya : Page
    {
        uchetnaya Uchet;
        bool checkNew;
        public dobavlenieUchetnaya(uchetnaya U)
        {
            InitializeComponent();
            if (U == null)
            {
                U = new uchetnaya();
                checkNew = true;

            }
            else
                checkNew = false;
            DataContext = Uchet = U;
        }
        
        
  

        private void dobavit_Click(object sender, RoutedEventArgs e)
        {
            if (checkNew)
            {   
                ConDB.context.uchetnaya.Add(Uchet);
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

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Nav.MFrame.GoBack();
        }

        private void litsschetttt_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(litsschetttt.Text.ToString()))
                {
                    int.Parse(litsschetttt.Text);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("не надо буквы и спецсимволы вводить!!!");
                litsschetttt.Text = "";
            }      
            

            
        }

        private void monthhhh_TextChanged(object sender, TextChangedEventArgs e)
        {
           
                if (!monthhhh.Text.All(char.IsDigit)) { }
               
                else
                {
                    MessageBox.Show("Сюда надо вводить буквы");
                    monthhhh.Text = "Январь";
                }
            
           
        }

        private void Tariiiiffff_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Tariiiiffff.Text.ToString()))
                {
                    int.Parse(Tariiiiffff.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("не надо буквы и спецсимволы вводить!!!");
                Tariiiiffff.Text = "";
            }

        }

        private void kvatti_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(kvatti.Text.ToString()))
                {
                    int.Parse(kvatti.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("не надо буквы и спецсимволы вводить!!!");
                kvatti.Text = "";
            }
        }
    }
}
