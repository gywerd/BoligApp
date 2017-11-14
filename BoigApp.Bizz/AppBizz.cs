using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligApp.Bizz
{
    public class AppBizz
    {
        #region Fields
        private Tennant CBT;
        private Apartment CBA;
        private Tennant tempTennant;
        private Apartment tempApartment;
        public ObservableCollection<Tennant> Tennants;
        public ObservableCollection<Apartment> Apartments;

        #endregion

        #region Constructors
        /// <summary>
        /// Empty constructor
        /// </summary>
        public AppBizz() { }

        #endregion

        #region Methods
        public void GetUpdate()
        {
            Tennants = CBT.LoadCollectionOfTennants();
            Apartments = CBA.LoadCollectionOfAppartments();
        }
        #endregion

        #region Properties
        public Tennant TempTennant { get => tempTennant; set => tempTennant = value; }
        public Apartment TempApartment { get => tempApartment; set => tempApartment = value; }
        #endregion
    }
}
