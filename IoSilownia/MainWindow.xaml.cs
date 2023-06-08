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
using System.Windows.Navigation;
using CMS.Ecommerce.AuthorizeNetDataContracts;
using IoSilownia.Utilities;

namespace IoSilownia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Trener_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("/view/Customer.xaml", UriKind.Relative));

        }

        private void Recepcja_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("/view/Form.xaml", UriKind.Relative));

        }
    }
}
