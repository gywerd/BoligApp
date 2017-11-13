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

namespace BoligApp.GUI
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

        private void OnMenuFilesClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuHelpAbout_Click(object sender, RoutedEventArgs e)
        {
             MessageBox.Show("BoligadministrationsApp (CRM) for\nABC Boliger A/S\n\nBoligApp 1.0", "Om BoligApp", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void On_ButtonTennants_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonApartements_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
