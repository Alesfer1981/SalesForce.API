using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Locations
{
    public class RateModel
    {
        /// <summary>
        /// Code column
        /// </summary>
        //[Required, StringLength(15), MinLength(6)]
        //public string id { get; set; }
        //private string ID
        //{
        //    get { return id; }
        //    set { id = value.Trim(); }
        //}

        /// <summary>
        /// Location Code
        /// </summary>
        [Required, StringLength(15), MinLength(6)]
        public string idLocation { get; set; }
        private string ID_LOCATION
        {
            get { return idLocation; }
            set { idLocation = value.Trim(); }
        }

        /// <summary>
        /// Code of payer
        /// </summary>
        public string idPayer { get; set; }
        private string ID_PAYER
        {
            get { return idPayer; }
            set { idPayer = value.Trim(); }
        }


        /// <summary>
        /// Payer Name
        /// </summary>
        public string namePayer { get; set; }
        private string PAYER
        {
            get { return namePayer; }
            set { namePayer = value.Trim(); }
        }

        /// <summary>
        /// Country code
        /// </summary>
        public string IdCountry { get; set; }
        private string ID_COUNTRY
        {
            get { return IdCountry; }
            set { IdCountry = value.Trim(); }
        }

        /// <summary>
        /// Country name
        /// </summary>
        public string nameCountry { get; set; }
        private string COUNTRY
        {
            get { return nameCountry; }
            set { nameCountry = value.Trim(); }
        }

        /// <summary>
        /// rate value 
        /// </summary>
        public decimal currentRate { get; set; }
        private decimal RATE
        {
            get { return currentRate; }
            set { currentRate = value; }
        }

        /// <summary>
        /// Cost rate vlaue
        /// </summary>
        public decimal currentCostRate { get; set; }
        private decimal COST_RATE
        {
            get { return currentCostRate; }
            set { currentCostRate = value; }
        }

        /// <summary>
        /// Spread value
        /// </summary>
        public decimal currentSpread { get; set; }
        private decimal SPREAD
        {
            get { return currentSpread; }
            set { currentSpread = value; }
        }

        /// <summary>
        /// Date to indicate since when is requeted data
        /// </summary>
        public string dateInsert { get; set; }
        private string DATE_INSERT
        {
            get { return dateInsert; }
            set { dateInsert = value.Trim(); }
        }

    }
}
