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
    /// Interaction logic for Form.xaml
    /// </summary>
    public partial class Form : UserControl
    {
        public Form()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbOptions.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedOption = selectedItem.Content.ToString();

                // Ustawienie widoczności odpowiedniego zdjęcia
                imgDostawca.Visibility = selectedOption == "Zaopatrzeniowiec" ? Visibility.Visible : Visibility.Collapsed;
                txtZaopatrzeniowiec1.Visibility = selectedOption == "Zaopatrzeniowiec" ? Visibility.Visible : Visibility.Collapsed;
                imgTechniczna.Visibility = selectedOption == "Techniczna" ? Visibility.Visible : Visibility.Collapsed;

                ilosc.Visibility = selectedOption == "Zaopatrzeniowiec" ? Visibility.Visible : Visibility.Collapsed;
                cmbOptions2_zp.Visibility = selectedOption == "Zaopatrzeniowiec" ? Visibility.Visible : Visibility.Collapsed;
                btnZaopatrzeniowiec.Visibility = selectedOption == "Zaopatrzeniowiec" ? Visibility.Visible : Visibility.Collapsed;
                txtNumber_zp.Visibility = selectedOption == "Zaopatrzeniowiec" ? Visibility.Visible : Visibility.Collapsed;
            }
            else
            {
                // Jeśli żadna opcja nie jest wybrana, ukryj wszystkie zdjęcia
                imgDostawca.Visibility = Visibility.Collapsed;
                imgTechniczna.Visibility = Visibility.Collapsed;
                txtZaopatrzeniowiec1.Visibility = Visibility.Collapsed;
                ilosc.Visibility = Visibility.Collapsed;
                cmbOptions2_zp.Visibility = Visibility.Collapsed;
                btnZaopatrzeniowiec.Visibility = Visibility.Collapsed;
                txtNumber_zp.Visibility = Visibility.Collapsed;


            }
        }




    }
}
