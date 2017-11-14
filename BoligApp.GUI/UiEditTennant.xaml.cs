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
    /// Interaction logic for UiEditTennant.xaml
    /// </summary>
    public partial class UiEditTennant : UserControl
    {
        private AppBizz CAB;
        private UserControl ucCenter;
        public UiEditTennant(AppBizz CAB, UserControl ucCenter)
        {
            InitializeComponent();
            this.CAB = CAB;
            this.ucCenter = ucCenter;
        }
    }
}
