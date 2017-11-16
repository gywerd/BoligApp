using BoligApp.Bizz;
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
        AppBizz CAB = new AppBizz();
        DataViewTennants ucTennants;
        DataViewApartments ucApartments;
        UiCreateTennant uiCreateTennant;

        public MainWindow()
        {
            InitializeComponent();
            CAB.GetUpdate();
            uiCreateTennant = new UiCreateTennant(CAB, userControlRight);
            userControlCenter.Content = ucTennants = new DataViewTennants(CAB, userControlCenter, userControlRight);
        }

        private void OnMenuFilesClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuHelpAbout_Click(object sender, RoutedEventArgs e)
        {
             MessageBox.Show("BoligadministrationsApp (CRM) for\nABC Boliger A/S\n\nBoligApp 1.0", "Om BoligApp", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void On_ButtonTennants_Click(object sender, RoutedEventArgs e)
        {
            userControlCenter.Content = ucTennants = new DataViewTennants(CAB, userControlRight, uiCreateTennant);
        }

        private void ButtonApartements_Click(object sender, RoutedEventArgs e)
        {
            userControlCenter.Content = ucApartments = new DataViewApartments(CAB, userControlRight, uiCreateTennant);
        }
    }
}
