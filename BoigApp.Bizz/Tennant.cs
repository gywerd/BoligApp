using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoigApp.Bizz
{
    public class Tennant
    {
        #region Fields
        private int id;
        private int zip;
        private string address;
        private string country;
        private string name;
        private string place;
        private string town;
        private DateTime birthday;
        #endregion

        #region Constructors
        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Tennant() { }

        /// <summary>
        /// Constructor, used when reading from database
        /// </summary>
        /// <param name="id">int</param>
        /// <param name="name">string</param>
        /// <param name="addr">string</param>
        /// <param name="zip">string</param>
        /// <param name="town">string</param>
        /// <param name="country">string</param>
        /// <param name="bDay">string</param>
        /// <param name="place">string</param>
        public Tennant(int id, string name, string addr, int zip, string town, string country, DateTime bDay, string place = "")
        {
            this.id = id;
            this.name = name;
            this.address = addr;
            this.place = place;
            this.zip = zip;
            this.town = town;
            this.country = country;
            this.birthday = bDay;
        }
        #endregion

        #region Events
        /// <summary>
        /// Event, that handles updating fields in UserControl
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        /// <summary>
        /// Method, that adds a new tennant to the database
        /// </summary>
        /// <param name="id">int</param>
        /// <param name="name">string</param>
        /// <param name="addr">string</param>
        /// <param name="zip">string</param>
        /// <param name="town">string</param>
        /// <param name="country">string</param>
        /// <param name="bDay">string</param>
        /// <param name="place">string</param>
        public void AddTennantToDatabase(int id, string name, string addr, int zip, string town, string country, DateTime bDay, string place = "")
        {

        }

        /// <summary>
        /// Method, that loads a collection of tennants from the database
        /// </summary>
        public ObservableCollection<Tennant> LoadCollectionOfTennants()
        {
            ObservableCollection<Tennant> t = new ObservableCollection<Tennant>();
            return t;
        }

        /// <summary>
        /// Method that broadcasts, when an entry is changed
        /// </summary>
        /// <param name="propertyName"></param>
        protected void Notify(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Place { get => place; set => place = value; }
        public int Zip { get => zip; set => zip = value; }
        public string Town { get => town; set => town = value; }
        public string Country { get => country; set => country = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        #endregion
    }
}
