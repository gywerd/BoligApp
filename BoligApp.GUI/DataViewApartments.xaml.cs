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
    /// Interaction logic for DataViewApartments.xaml
    /// </summary>
    public partial class DataViewApartments : UserControl
    {
        private AppBizz CAB;
        private UserControl ucCenter;
        private UserControl ucRight;

        public DataViewApartments(AppBizz CAB, UserControl ucCenter, UserControl ucRight)
        {
            InitializeComponent();
            this.CAB = CAB;
            this.ucCenter = ucCenter;
            this.ucRight = ucRight;
        }

        private void TextBoxFilterApartements_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGridApartements_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CAB.TempApartment = (Apartment)dataGridApartments.SelectedItem;
            UiEditApartment uiEditApartment = new UiEditApartment(CAB, ucCenter);
            ucRight = uiEditApartment;
        }

        private void BtnCreateApartment_Click(object sender, RoutedEventArgs e)
        {
            UiCreateApartment uiCreateApartment = new UiCreateApartment(CAB, ucCenter);
            ucRight = uiCreateApartment;
        }
    }
}
