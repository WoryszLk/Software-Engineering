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

namespace IoSilownia.View
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = txtSearch.Text;
            // Przykładowa logika wyszukiwania
            if (!string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Wyszukano: " + searchText);
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string searchText = textBox.Text;
            // Wykonaj operacje wyszukiwania na podstawie wartości searchText
            // Na przykład, zaktualizuj widok lub wykonaj inne odpowiednie działania.
        }

        private void cmbUserActions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbUserActions.SelectedItem as ComboBoxItem != null)
            {
                string selectedAction = (cmbUserActions.SelectedItem as ComboBoxItem).Content.ToString();

                if (selectedAction == "Usuń użytkownika" || selectedAction == "Znajdź użytkownika")
                {
                    Text_boximp.Visibility = Visibility.Visible;
                    Text_Name.Visibility = Visibility.Visible;
                    Text_LastName.Visibility = Visibility.Visible;
                    Text_Brth.Visibility = Visibility.Visible;
                }
                else
                {
                    Text_boximp.Visibility = Visibility.Collapsed;
                    Text_Name.Visibility = Visibility.Collapsed;
                    Text_LastName.Visibility = Visibility.Collapsed;
                    Text_Brth.Visibility= Visibility.Collapsed;
                }
            }
        }






    }
}
