using Microsoft.AspNetCore.SignalR;
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
    /// Interaction logic for Training.xaml
    /// </summary>
    public partial class Training : UserControl
    {
        public Training()
        {
            InitializeComponent();
        }


        private void combo_opt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combo_opt.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedOption = selectedItem.Content.ToString();

                // Sprawdzenie wybranej opcji
                if (selectedOption == "Silownia" || selectedOption == "Sztuki walki" || selectedOption == "Fitness")
                {
                    Trener_txt.Visibility = Visibility.Visible;
                    trener_ch.Visibility = Visibility.Visible;
                }
                else
                {
                    Trener_txt.Visibility = Visibility.Collapsed;
                    trener_ch.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                
            }
        }
    }
}
