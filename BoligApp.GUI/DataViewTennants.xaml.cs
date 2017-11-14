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
using BoligApp.Bizz;

namespace BoligApp.GUI
{
    /// <summary>
    /// Interaction logic for DataViewTennants.xaml
    /// </summary>
    public partial class DataViewTennants : UserControl
    {
        private AppBizz CAB;
        private UserControl ucCenter;
        private UserControl ucRight;


        public DataViewTennants(AppBizz CAB, UserControl ucCenter, UserControl ucRight)
        {
            InitializeComponent();
            this.CAB = CAB;
            this.ucRight = ucRight;
            this.ucCenter = ucCenter;
        }

        #region Methods
        public DataViewTennants()
        {
        }

        private void TextBoxFilterTennants_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGridTennants_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnCreateTennant_Click(object sender, RoutedEventArgs e)
        {
            UiCreateTennant uiCreateTennant = new UiCreateTennant(CAB, ucCenter);
            ucRight = uiCreateTennant;
        }
        #endregion
    }
}
