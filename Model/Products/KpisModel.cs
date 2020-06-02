using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Products
{
    public class KpisModel
    {
        /// <summary>
        /// code
        /// </summary>
        [Required, StringLength(10), MinLength(3)]
        public int id { get; set; }       

        /// <summary>
        /// Name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Product code
        /// </summary>
        [Required, StringLength(10), MinLength(5)]
        public string idProduct { get; set; }
        private string ID_PRODUCT
        {
            get { return idProduct; }
            set { idProduct = value.Trim(); }
        }

        /// <summary>
        /// Location code
        /// </summary>
        [Required, StringLength(10), MinLength(5)]
        public string idLocation { get; set; }
        private string ID_LOCATION
        {
            get { return idLocation; }
            set { idLocation = value.Trim(); }
        }

        /// <summary>
        /// Payer
        /// </summary>
        [Required, StringLength(10), MinLength(5)]
        public string payer { get; set; }
        private string PAYER
        {
            get { return payer; }
            set { payer= value.Trim(); }
        }

        /// <summary>
        /// Country
        /// </summary>
        [Required, StringLength(10), MinLength(5)]
        public string country { get; set; }
        private string COUNTRY
        {
            get { return country; }
            set { country = value.Trim(); }
        }

        /// <summary>
        /// User
        /// </summary>
        [Required, StringLength(10), MinLength(5)]
        public string user { get; set; }
        private string USER
        {
            get { return user; }
            set { user = value.Trim(); }
        }

        /// <summary>
        /// Date
        /// </summary>
        public DateTime date { get; set; }
        private DateTime DATE
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// Hour
        /// </summary>
        public int hour { get; set; }
        private int HOUR
        {
            get { return hour; }
            set { hour = value; }
        }

        /// <summary>
        /// Value
        /// </summary>
        public decimal value { get; set; }

    }
}
