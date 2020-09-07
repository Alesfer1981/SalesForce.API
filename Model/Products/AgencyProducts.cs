using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Products
{
    public class AgencyProducts
    {
        /// <summary>
        /// code
        /// </summary>
        [Required, StringLength(10), MinLength(3)]
        public int id { get; set; }  
        private int ID {
        get { return id; } set { id = value; }
        }    

        /// <summary>
        /// Name
        /// </summary>
        public string idProduct { get; set; }  
        private string ID_PRODUCT {
        get { return idProduct; } set { idProduct = value; }
        }    
        
        public string idLocation { get; set; }  
        private string ID_LOCATION {
        get { return idLocation; } set { idLocation = value; }
        }  

        public string payer { get; set; }  
        private string PAYER {
        get { return payer; } set { payer = value; }
        }  

        public string country { get; set; }  
        private string COUNTRY {
        get { return country; } set { country = value; }
        }  

        public string user { get; set; }  
        private string USER {
        get { return user; } set { user = value; }
        }  

       
        public string date { get; set; }  
        private string DATE {
        get { return date; } set { date = value; }
        }  


        public string count { get; set; }  
        private string COUNT {
        get { return count; } set { count = value; }
        }  

        public string gp { get; set; }  
        private string GP {
        get { return gp; } set { gp = value; }
        }  


        public string mGp { get; set; }  
        private string mGP {
        get { return mGp; } set { mGp = value; }
        }  

        public string amount { get; set; }  
        private string AMOUNT {
        get { return amount; } set { amount = value; }
        }  


        public string countBudget { get; set; }  
        private string COUNT_BUDGET {
        get { return countBudget; } set { countBudget = value; }
        }  

        public string gpBudget { get; set; }  
        private string GP_BUDGET {
        get { return gpBudget; } set { gpBudget = value; }
        } 

        public string amountBudget { get; set; }  
        private string AMOUNT_BUDGET {
        get { return amountBudget; } set { amountBudget = value; }
        } 

        public string rebates { get; set; }  
        private string REBATES {
        get { return rebates; } set { rebates = value; }
        }

        public string monthsAgo { get; set; }  
        private string MONTHS_AGO {
        get { return monthsAgo; } set { monthsAgo = value; }
        }

        public string viaTasa { get; set; }  
        private string VIA_TASA {
        get { return viaTasa; } set { viaTasa = value; }
        }

        public string viaTasaAgency { get; set; }  
        private string VIA_TASA_AGENCY {
        get { return viaTasaAgency; } set { viaTasaAgency = value; }
        }

    }
}
